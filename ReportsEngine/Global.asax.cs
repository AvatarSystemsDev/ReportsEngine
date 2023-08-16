using DevExpress.Security.Resources;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.Web.WebDocumentViewer;
//using DocumentOperationServiceSample.Services;
using ReportsEngine.Services;
using System;
using System.IO;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace ReportsEngine
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions;
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new CustomReportStorageWebExtension(Server.MapPath("/Reports")));
            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize(ProcessException);
            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize(new ErrorLoggerService());
            // Allow style sheets to be loaded only from the "C:\\StaticResources\\" file directory
            AccessSettings.ReportingSpecificResources.SetRules(DirectoryAccessRule.Allow(Server.MapPath("/Styles")));
            DefaultWebDocumentViewerContainer.Register<DocumentOperationService, ServiceOperations>();
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
            MVCxReportDesigner.StaticInitialize();
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
            //TODO: Handle Exception
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            EnableCrossDomain();
        }

        static void EnableCrossDomain()
        {
            string origin = HttpContext.Current.Request.Headers["Origin"];
            if (string.IsNullOrEmpty(origin)) return;
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", origin);
            string method = HttpContext.Current.Request.Headers["Access-Control-Request-Method"];
            if (!string.IsNullOrEmpty(method))
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", method);
            string headers = HttpContext.Current.Request.Headers["Access-Control-Request-Headers"];
            if (!string.IsNullOrEmpty(headers))
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", headers);
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Credentials", "true");
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.StatusCode = 204;
                HttpContext.Current.Response.End();
            }
        }

        void ProcessException(Exception ex, string message)
        {
            // Log exceptions here. For instance:
            System.Diagnostics.Debug.WriteLine("[{0}]: Exception occured. Message: '{1}'. Exception Details:\r\n{2}",
                DateTime.Now, message, ex);
        }
    }

    public class ErrorLoggerService : DevExpress.XtraReports.Web.ClientControls.LoggerService
    {
        public override void Info(string message)
        {
            System.Diagnostics.Debug.WriteLine("[{0}]: Info: '{1}'.", DateTime.Now, message);
        }
        public override void Error(Exception exception, string message)
        {
            DebugErrorHandler.Error_Occurred(exception);
            System.Diagnostics.Debug.WriteLine("[{0}]: Exception occured. Message: '{1}'. Exception Details:\r\n{2}",
                DateTime.Now, message, exception);
        }
    }

    public class DebugErrorHandler
    {
        public static void Error_Occurred(Exception ex = null)
        {
            if (ex != null)
            {
                string separation = "-----------------------------------------------------------" + Environment.NewLine;
                string message = string.Format("Time: {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")) + Environment.NewLine;
                message += separation;
                message += string.Format("Application: {0}", "Providence") + Environment.NewLine;
                message += string.Format("Message: {0}", ex.Message) + Environment.NewLine;
                /*
                message += string.Format("InnerException : {0}", ex.InnerException?.Message) + Environment.NewLine;
                message += string.Format("StackTrace: {0}", ex.StackTrace) + Environment.NewLine;
                message += string.Format("Source: {0}", ex.Source) + Environment.NewLine;
                message += string.Format("TargetSite: {0}", ex.TargetSite.ToString()) + Environment.NewLine;
                */
                message += separation;

                string folder = @"C:\ServiceErrorLogs";
                string filePath = @"\ReportEngineErrors.txt";
                string strPath = folder + filePath;
                System.IO.Directory.CreateDirectory(folder);
                using (StreamWriter writer = new StreamWriter(strPath, true))
                {
                    writer.WriteLine(message);
                    writer.Close();
                }
            }
        }

    }
}