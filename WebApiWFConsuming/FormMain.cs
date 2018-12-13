using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiEFModel;

namespace WebApiWFConsuming
{
    public partial class FormMain : Form
    {
        public Boolean NewSupplier = false;
        public FormMain()
        {
            InitializeComponent();
        }
//        private async Task<string> GetBrandAsync(HttpResponseMessage contextContent)
        private async void GetBrandAsync()
        {

            // invoking API
            string basepath = txtApiUrl.Text;
            string path = basepath + "/api/BRAND" ;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;

            // reading Api as String, just to show text results into a TextBox
            var result = await response.Content.ReadAsStringAsync();
            txtGetResult.Text = result;

            // serializing object to use get some columns before rendering into gridview
            // Notice that here we have access in the class BRAND into the package WebApiEFModel
            // but if not, you should create your "class" based on Json results
            IList<BRAND> brand = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<BRAND>>(result);
            
            // selecting just interest columns
            var cols = from b in brand
                       select new { b.ID_BRAND, b.DSC_BRAND, b.ID_SUPPLIER, b.SUPPLIER.DSC_SUPPLIER };
            dgvGetResult.DataSource = null;
            dgvGetResult.DataSource = cols.ToList();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            GetBrandAsync();
        }


        private async Task<IList<SUPPLIER>> GetSupplierAsync()
        {
            // invoking API
            string basepath = txtApiUrl.Text;
            string path = basepath + "/api/" + "SUPPLIER";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;

            // reading Api as String, just to show text results into a TextBox

            var supplier = await response.Content.ReadAsAsync<IList<SUPPLIER>>();
            sUPPLIERBindingSource.DataSource = supplier;
            return supplier;
        }
        private async void SaveNewSupplier()
        {
            // invoking API
            string basepath = txtApiUrl.Text;
            string path = basepath + "/api/" + "SUPPLIER";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);

            string json_post = Newtonsoft.Json.JsonConvert.SerializeObject((sUPPLIERBindingSource[sUPPLIERBindingSource.Position] as SUPPLIER));
            await client.PostAsJsonAsync(path, (sUPPLIERBindingSource[sUPPLIERBindingSource.Position] as SUPPLIER));
            GetSupplierAsync();
        }
        private async void DeleteSupplier(int id)
        {
            string basepath = txtApiUrl.Text;
            string path = basepath + "/api/" + "SUPPLIER/"+id.ToString();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage delete = await client.DeleteAsync(path);
            // please, get the results and treat
            // in this case the web api is returning an object (SUPPLIER)
            string result = await delete.Content.ReadAsStringAsync();

            // reflects the change in the gridview
            // because datasource is connected 
            sUPPLIERBindingSource.RemoveCurrent();
        }
        private async void UpdateSupplier(int id)
        {
            string basepath = txtApiUrl.Text;
            string path = basepath + "/api/" + "SUPPLIER/" + id.ToString();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);

            // Api is waiting for a SUPPLIER parameter,
            // here I create in memory a new one, just to ignore the relationship between Supplier and Brand
            // please, check data model representation
            SUPPLIER json_post = new SUPPLIER();
            json_post.ID_SUPPLIER = Convert.ToInt32(txtSupplierID.Text);
            json_post.DSC_SUPPLIER = txtSupplierName.Text;
            json_post.DATE_OF_REGISTER = Convert.ToDateTime(txtSupplierDate.Text);

            HttpResponseMessage update = await client.PutAsJsonAsync(path, json_post);

            // please, get the results and treat
        }


        private void btnGetSupplier_Click(object sender, EventArgs e)
        {
            GetSupplierAsync();
        }
        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            SUPPLIER s = (sUPPLIERBindingSource.AddNew() as SUPPLIER);
            s.DATE_OF_REGISTER = DateTime.UtcNow;
            NewSupplier = true;
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            //dgvSupplier.Rows.Add()
            if (NewSupplier)
            {

                SaveNewSupplier();
                // the return needs to be treated 
                NewSupplier = false;
                
            }
        }

        private void dgvSupplier_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NewSupplier = true;
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            Validate();
            NewSupplier = false;
            UpdateSupplier(Convert.ToInt32(txtSupplierID.Text));
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DataGridViewRow dvr = (DataGridViewRow );
            DeleteSupplier(Convert.ToInt32(txtSupplierID.Text));
        }
    }
}
