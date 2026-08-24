using System;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace Localization
{
    public partial class Form1 : Form
    {
        //==========================================================================================================
        ResourceManager m_resourceManger = null;
        //==========================================================================================================
        public Form1()
        {
            InitializeComponent();
            // Init m_resourceManger
            m_resourceManger = new ResourceManager("Localization.Localization", Assembly.GetExecutingAssembly());
            // Init UICulture to CurrentCulture
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            // Init Controls
            UpdateUIControls();
        }
        //==========================================================================================================
        private void UpdateUIControls()
        {
            try
            {
                if (m_resourceManger != null)
                {
                    this.Text = m_resourceManger.GetString("A demo application");
                    this.lblTrans.Text = m_resourceManger.GetString("String");
                    this.lblMessage.Text = m_resourceManger.GetString("This is a demo application for localization");
                    this.grpLanguages.Text = m_resourceManger.GetString("Select a language");
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //==========================================================================================================
        private void OnLanguageChange(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string culture = string.Empty;

            switch(radioButton.Text)
            {
                case "U.S. English (en-US)":
                    culture = "en-US";
                    break;
                case "German-Germany (de-DE)":
                    culture = "de-DE";
                    break;
                case "French - France (fr-FR)":
                    culture = "fr-FR";
                    break;
                case "Portuguese - Brazil (pt-BR)":
                    culture = "pt-BR";
                    break;
            }

            // This is used for the language of the user interface
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            // This is used with formatting and sort options (e.g. number and date formats)
            // e.g. a float value 2.352 will be 2,3.52 if CurrentCulture is set to de-DE
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);

            /************************************************************************/
            /*  Below code can be used to set default language if the required one is not found.
             *  This can also be done by specifying 
             *  [assembly: NeutralResourcesLanguageAttribute("en-US", UltimateResourceFallbackLocation.Satellite)]
             *  in AssemblyInfo.cs                                                  */
            /************************************************************************/
            /*if (m_resourceManger != null && m_resourceManger.GetResourceSet(Thread.CurrentThread.CurrentUICulture, true, false) == null)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            }*/

            UpdateUIControls();
        }
        //==========================================================================================================
    }
}
