using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductAPI
{

    public partial class Database_stuff : System.Web.UI.Page
    {
        Controllers.ProductController productController = new Controllers.ProductController();
        protected void Page_Load(object sender, EventArgs e)
        {
         
         
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            Product prod = new Product();
            prod.Name = tbName.Text;
            if (tbPrice.Text == "" || tbPrice.Text == null)
            {
                prod.Price = 0;
            }
            else
            {
                prod.Price = Convert.ToDouble(tbPrice.Text);
            }
            prod.Description = tbDesc.Text;
            productController.Add(prod);
            Response.Redirect(Request.RawUrl);

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
          //  lbResult.Text = "";
            
            try {
                Product prod = new Product();
                prod.ProductID = Convert.ToInt32(tbProdId.Text);
                    prod.Name = tbName.Text;
                if (tbPrice.Text == "" || tbPrice.Text == null)
                {
                    prod.Price = 0;
                }
                else
                {
                    prod.Price = Convert.ToDouble(tbPrice.Text);
                }
                    prod.Description = tbDesc.Text;
                    productController.Edit(prod);




                lbResult.Visible = true;
                GridView1.DataBind();
                

             //   Response.Redirect(Request.RawUrl);


            }
            catch {
                lbResult.Visible = false;

            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";

            try
            {
                productController.Delete(Convert.ToInt32(tbProdId.Text));
                Response.Redirect(Request.RawUrl);
            }
            catch { }
        }

        protected void btnGetProd_Click(object sender, EventArgs e)
        {
            Product prod = productController.Get(Convert.ToInt32(tbProdId.Text));
            tbDesc.Text = prod.Description;
            tbName.Text = prod.Name;
            tbPrice.Text = prod.Price.ToString();
        }
    }
}