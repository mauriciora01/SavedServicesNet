//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Dataifx.Trading.Activity {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class AutenticationActivity : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private System.Activities.InArgument<string> _strIdUser;
        
        private System.Activities.InArgument<string> _strPassword;
        
        private System.Activities.InOutArgument<Dataifx.Trading.CommonObjects.InfoUsuario> _iu;
        
        private System.Activities.OutArgument<Dataifx.Trading.CommonObjects.EstadoAutenticacion> _autenticationState;
        
        private System.Activities.InArgument<int> _IdFirma;
        
        private System.Activities.InArgument<string> _strIpAddress;
        
        private System.Activities.OutArgument<bool> _ValidateOTP;
        
        private System.Activities.OutArgument<string> _NumeroDocumento;
        
        private System.Activities.OutArgument<string> _UserEmail;
        
        private System.Activities.InArgument<bool> _validatepassword;
        
        private System.Activities.InArgument<string> _argument1;
        
partial void BeforeInitializeComponent(ref bool isInitialized);

partial void AfterInitializeComponent();

        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "15.0.0.0")]
        public AutenticationActivity() {
            this.InitializeComponent();
        }
        
        public System.Activities.InArgument<string> strIdUser {
            get {
                return this._strIdUser;
            }
            set {
                this._strIdUser = value;
            }
        }
        
        public System.Activities.InArgument<string> strPassword {
            get {
                return this._strPassword;
            }
            set {
                this._strPassword = value;
            }
        }
        
        public System.Activities.InOutArgument<Dataifx.Trading.CommonObjects.InfoUsuario> iu {
            get {
                return this._iu;
            }
            set {
                this._iu = value;
            }
        }
        
        public System.Activities.OutArgument<Dataifx.Trading.CommonObjects.EstadoAutenticacion> autenticationState {
            get {
                return this._autenticationState;
            }
            set {
                this._autenticationState = value;
            }
        }
        
        public System.Activities.InArgument<int> IdFirma {
            get {
                return this._IdFirma;
            }
            set {
                this._IdFirma = value;
            }
        }
        
        public System.Activities.InArgument<string> strIpAddress {
            get {
                return this._strIpAddress;
            }
            set {
                this._strIpAddress = value;
            }
        }
        
        public System.Activities.OutArgument<bool> ValidateOTP {
            get {
                return this._ValidateOTP;
            }
            set {
                this._ValidateOTP = value;
            }
        }
        
        public System.Activities.OutArgument<string> NumeroDocumento {
            get {
                return this._NumeroDocumento;
            }
            set {
                this._NumeroDocumento = value;
            }
        }
        
        public System.Activities.OutArgument<string> UserEmail {
            get {
                return this._UserEmail;
            }
            set {
                this._UserEmail = value;
            }
        }
        
        public System.Activities.InArgument<bool> validatepassword {
            get {
                return this._validatepassword;
            }
            set {
                this._validatepassword = value;
            }
        }
        
        public System.Activities.InArgument<string> argument1 {
            get {
                return this._argument1;
            }
            set {
                this._argument1 = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "15.0.0.0")]
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
            System.IO.Stream initializeXaml = typeof(AutenticationActivity).Assembly.GetManifestResourceStream(resourceName);
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
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(AutenticationActivity));
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "15.0.0.0")]
        private string FindResource() {
            string[] resources = typeof(AutenticationActivity).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".AutenticationActivity.g.xaml") || resource.Equals("AutenticationActivity.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "15.0.0.0")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "15.0.0.0")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}
