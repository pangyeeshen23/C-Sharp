using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class AccessModifiers
    {

        public void Run()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessFields();
            derivedClass.ShowFields();
        }

    }

    class BaseClass
    {
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, " + $"Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccessFields()
        {
            this.publicField = 1;
            this.protectedField = 2;
            //this.privateField = 1;
        }
    }
}
