using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Mod5Demo1;

namespace Mod5Demo1
{
    abstract class Beverage
    {
        private int id;
        public int Id { get { return id; } } // to return to private int id

        public string Name { get; }

        public Beverage(int id)
        {
            this.id = id;
        }

        // no logic, so its abstract method 
        //so we need to have a dedrived classs to have implementation 
        public abstract double CalculatePrice();
        public virtual void SetBaseTemp() // since its virtual , we need have a logic to write 
        {
            throw new NotImplementedException();
        //logic
        }
    }
    sealed class Coffee: Beverage // sealed 使得coffe 是最后面的class 
    {
        public Coffee (int id, string bean): base (id) // reason why id need to be beacuase there is a Beverage base calss has id 
        {
            this.Bean = bean;
        }
        public string Bean { get; set; }

        public sealed override void SetBaseTemp() //sealed 可以用在method，不要override
        {
            //base.SetBaseTemp(); 
        }




        public override double CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }

   
}
       
 