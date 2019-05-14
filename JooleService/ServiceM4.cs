using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleRepository;
using Joole_DAL;

namespace JooleService
{
    public partial class Service
    {
        public static readonly Joole_TeamEntities context = new Joole_TeamEntities();
        UnitOfWork uow = new UnitOfWork(context);
        protected readonly DbContext Context;
        public Service(DbContext context)
        {
            Context = context;
        }

        //search result
        //products list
        //get model year
        public List<tblProduct> GetProducts()
        {
            List<tblProduct> products = new List<tblProduct>();
            var productresult = uow.Product.GetAll();
            foreach (var item in productresult)
            {
                tblProduct prod = new tblProduct();
                prod.ProductID = item.ProductID;
                prod.ProductName = item.ProductName;
                prod.Series = item.Series;
                prod.ModelYear = item.ModelYear;
                prod.ProductImagePath = item.ProductImagePath;
                products.Add(prod);
            }
            return products;
        }

        public List<tblProduct> GetModelyear()
        {
            List<tblProduct> model = new List<tblProduct>();
            var modelresult = uow.Product.GetAll();
            foreach (var item in modelresult)
            {
                tblProduct mo = new tblProduct();
                mo.ProductID = item.ProductID;
                mo.ModelYear = item.ModelYear;
                model.Add(mo);
            }
            return model;
        }

        
        public List<tblType> GetProductType()
        {
            List<tblType> type = new List<tblType>();
            var typeresult = uow.Type.GetAll();
            foreach (var item in typeresult)
            {
                tblType tp = new tblType();
                tp.TypeID = item.TypeID;
                type.Add(tp);

            }
            return type;
        }


        //Range slider value
        //filter=====tblTypeSpecValue
        public List<tblTypeSpecValue> GetFilterValues()
        {
            List<tblTypeSpecValue> spec = new List<tblTypeSpecValue>();
            var specresult = uow.TypeSpecValue.GetAll();
            foreach (var item in specresult)
            {
                tblTypeSpecValue sp = new tblTypeSpecValue();
                sp.TypeSpecID = item.TypeID;
                spec.Add(sp);
            }
            return spec;
        }

        public List<tblManufacturer> GetManuValue()
        {
            List<tblManufacturer> manu = new List<tblManufacturer>();
            var manuresult = uow.Manufacture.GetAll();
            foreach (var item in manuresult)
            {
                tblManufacturer m = new tblManufacturer();
                m.ManufacturerID = item.ManufacturerID;
                m.ManufacturerName = item.ManufacturerName;
                manu.Add(m);
            }
            return manu;
        }

        public List<tblProduct> GetProductValue()
        {
            List<tblProduct> pro = new List<tblProduct>();
            var proresult = uow.Product.GetAll();
            foreach (var item in proresult)
            {
                tblProduct p = new tblProduct();
                p.ProductID = item.ProductID;
                p.ProductName = item.ProductName;
                pro.Add(p);

            }
            return pro;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        //compare 
        public void Compare()
        {
            throw new NotImplementedException();
        }
    }
}
