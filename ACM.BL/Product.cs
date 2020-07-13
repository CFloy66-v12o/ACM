using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        private string _name;
        public string Name
        {
            get
            {
                
                return _name.InsertSpaces();
            }
            set
            {
                _name = value;
            }
        }

        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int ProductId { get; private set; }
        public string Log() => $"{ProductId}: {Name} Detail: {Description} Status: {EntityState}";
        public override string ToString() => Name;


        public bool Save()
        {



            return true;
        }

       

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (Price == null) isValid = false;

            return isValid;
        }
    }
}

    
    

    
        
    
    
       
    
