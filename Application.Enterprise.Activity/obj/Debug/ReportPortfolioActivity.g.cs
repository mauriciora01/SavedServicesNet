//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Application.Enterprise.Activity {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class ReportPortfolioActivity : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private System.Activities.InArgument<int> _IdFirma;
        
        private System.Activities.InArgument<string> _strIdComercial;
        
        private System.Activities.InArgument<Application.Enterprise.CommonObjects.InfoUsuario> _MyUser;
        
        private System.Activities.InOutArgument<System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>> _MyPortfolio;
        
partial void BeforeInitializeComponent(ref bool isInitialized);

partial void AfterInitializeComponent();

        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        public ReportPortfolioActivity() {
            this.InitializeComponent();
        }
        
        public System.Activities.InArgument<int> IdFirma {
            get {
                return this._IdFirma;
            }
            set {
                this._IdFirma = value;
            }
        }
        
        public System.Activities.InArgument<string> strIdComercial {
            get {
                return this._strIdComercial;
            }
            set {
                this._strIdComercial = value;
            }
        }
        
        public System.Activities.InArgument<Application.Enterprise.CommonObjects.InfoUsuario> MyUser {
            get {
                return this._MyUser;
            }
            set {
                this._MyUser = value;
            }
        }
        
        public System.Activities.InOutArgument<System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>> MyPortfolio {
            get {
                return this._MyPortfolio;
            }
            set {
                this._MyPortfolio = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        public void InitializeComponent() {
            if ((this._contentLoaded == true)) {
                return;
            }
            this._contentLoaded = true;
            bool isInitialized = false;
            this.BeforeInitializeComponent(ref isInitialized);
            if ((isInitialized == true)) {
                this.AfterInitializeComponent();
                return;
            }
            string resourceName = this.FindResource();
            System.IO.Stream initializeXaml = typeof(ReportPortfolioActivity).Assembly.GetManifestResourceStream(resourceName);
            System.Xml.XmlReader xmlReader = null;
            System.Xaml.XamlReader reader = null;
            System.Xaml.XamlObjectWriter objectWriter = null;
            try {
                System.Xaml.XamlSchemaContext schemaContext = XamlStaticHelperNamespace._XamlStaticHelper.SchemaContext;
                xmlReader = System.Xml.XmlReader.Create(initializeXaml);
                System.Xaml.XamlXmlReaderSettings readerSettings = new System.Xaml.XamlXmlReaderSettings();
                readerSettings.LocalAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                readerSettings.AllowProtectedMembersOnRoot = true;
                reader = new System.Xaml.XamlXmlReader(xmlReader, schemaContext, readerSettings);
                System.Xaml.XamlObjectWriterSettings writerSettings = new System.Xaml.XamlObjectWriterSettings();
                writerSettings.RootObjectInstance = this;
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(ReportPortfolioActivity));
                objectWriter = new System.Xaml.XamlObjectWriter(schemaContext, writerSettings);
                System.Xaml.XamlServices.Transform(reader, objectWriter);
            }
            finally {
                if ((xmlReader != null)) {
                    ((System.IDisposable)(xmlReader)).Dispose();
                }
                if ((reader != null)) {
                    ((System.IDisposable)(reader)).Dispose();
                }
                if ((objectWriter != null)) {
                    ((System.IDisposable)(objectWriter)).Dispose();
                }
            }
            this.AfterInitializeComponent();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        private string FindResource() {
            string[] resources = typeof(ReportPortfolioActivity).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".ReportPortfolioActivity.g.xaml") || resource.Equals("ReportPortfolioActivity.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}
