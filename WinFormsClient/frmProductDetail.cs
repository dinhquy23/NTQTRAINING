using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsClient
{
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }
        static GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5009");
        static ProductDetailsServices.ProductDetailsServicesClient client = new ProductDetailsServices.ProductDetailsServicesClient(channel);
        static ProductsServices.ProductsServicesClient clientProduct = new ProductsServices.ProductsServicesClient(channel);
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            var lisProductDetail = client.GetAll(new ProductDetailEmpty());
            dgvProductDetail.DataSource = ListProductDetailToDataTable(lisProductDetail);

            var listProduct = clientProduct.GetAll(new ProductEmpty());
            cbbCategoryId.DataSource = ToDataTable(listProduct);
            cbbCategoryId.ValueMember = "Id";
            cbbCategoryId.DisplayMember = "Name";
        }

        public DataTable ToDataTable(ListProduct listData)
        {
            DataTable dt = new DataTable();

            PropertyInfo[] Props = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dt.Columns.Add(prop.Name);
            }

            foreach (var item in listData.Items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        public DataTable ListProductDetailToDataTable(ListProductDetail listData)
        {
            DataTable dt = new DataTable();

            PropertyInfo[] Props = typeof(ProductDetail).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dt.Columns.Add(prop.Name);
            }

            foreach (var item in listData.Items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProductDetail product = new ProductDetail();
            product.Price = txtPrice.Text;
            product.Color = txtTagName.Text;
            product.MadeBy = txtMadeBy.Text;
            product.ProductId = int.Parse((string)cbbCategoryId.SelectedValue);
            product.StartingDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeStartingDate.Value, DateTimeKind.Utc));
            product.ClosingDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeClosingDate.Value, DateTimeKind.Utc));
            product.CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeCreate.Value, DateTimeKind.Utc));
            product.UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeUpdate.Value, DateTimeKind.Utc));

            ProductDetailResponseResult repon = client.Create(product);
            if (repon.Result == true)
            {
                MessageBox.Show("Create Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmProductDetail_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Create Not Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDetailId productId = new ProductDetailId();
            productId.Id = int.Parse(txtId.Text);
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Create Not Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult tl = MessageBox.Show($"Do you want to delete {txtId.Text} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    ProductDetailResponseResult result = client.Delete(productId);
                    if (result.Result == true)
                    {
                        MessageBox.Show("Delete Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot Delete", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                frmProductDetail_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductDetail product = new ProductDetail();
            product.Id = int.Parse(txtId.Text);
            product.Price = txtPrice.Text;
            product.Color = txtTagName.Text;
            product.MadeBy = txtMadeBy.Text;
            product.ProductId = int.Parse((string)cbbCategoryId.SelectedValue);
            product.StartingDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeStartingDate.Value, DateTimeKind.Utc));
            product.ClosingDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeClosingDate.Value, DateTimeKind.Utc));
            product.CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeCreate.Value, DateTimeKind.Utc));
            product.UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeUpdate.Value, DateTimeKind.Utc));


            ProductDetailResponseResult responseSesult = client.Update(product);
            if (responseSesult.Result == true)
            {
                MessageBox.Show("Update Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmProductDetail_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Cannot Update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtId.Text = dgvProductDetail.Rows[index].Cells["Id"].Value.ToString();
            txtTagName.Text = dgvProductDetail.Rows[index].Cells["Color"].Value.ToString();
            txtPrice.Text = dgvProductDetail.Rows[index].Cells["Price"].Value.ToString();
            txtMadeBy.Text = dgvProductDetail.Rows[index].Cells["MadeBy"].Value.ToString();
            cbbCategoryId.Text = dgvProductDetail.Rows[index].Cells["ProductId"].Value.ToString();
        }
    }
}
