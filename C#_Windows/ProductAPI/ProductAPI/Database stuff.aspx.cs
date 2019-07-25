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
         
            IEnumerable<Product> ls = productController.GetAll();
            for (int i = 0; i< ls.Count(); i++) {
                            }
            
            
        }
    }
}