using PSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.Areas.Base.Controllers
{
    public class ProductController : Controller
    {
        PSSEntities1 db = new PSSEntities1();

        // GET: Base/Product
        public ActionResult Product()
        {
            return View();
        }

        /// <summary>
        /// 查询商品
        /// </summary>
        /// <returns></returns>
        public ActionResult ProductList(int rows,int page,int kid=0) 
        {
            //查询商品类别的总数
            var total = (from a in db.v_Product
                         where a.Deleted == false
                         && (kid == 0 || a.KindID == kid)
                         select a).Count();
            //查询商品信息进行分页
            var list = (from a in db.v_Product
                        where a.Deleted == false
                        && (kid == 0 || a.KindID == kid)
                        orderby a.ID, a.OrderIndex
                        select a
                            ).Skip((page - 1) * rows).Take(rows).ToList();

            //返回一个json数据
            return Json(new
            {
                total = total,
                rows = list
            }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 得到所有商品类别
        /// </summary>
        public ActionResult ProductKinds()
        {
            var list = (from a in db.ProductKind
                        where a.Deleted == false
                        orderby a.OrderIndex
                        select new TreeNode()
                        {
                            id = a.ID,
                            text = a.KindName,
                            iconCls = null
                        }).ToList();
            list.Insert(0, new TreeNode()
            {
                id = 0,
                text = "全部类别"
            });
            return Json(list.ToList(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Kindadd(ProductKind p)
        {
            p.Deleted = false;
            db.ProductKind.Add(p);
            return Json(db.SaveChanges());
        }
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Kindedit(ProductKind p)
        {
            p.Deleted = false;
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            return Json(db.SaveChanges());
        }

        /// <summary>
        /// 删除一条类别
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteKind(int kid) 
        {
            if ((from a in db.Product where a.KindID == kid select a).Count()>0)
            {
                return JavaScript("$.messger.alert('警告','删除失败');");
            }
            //ProductKind p = new ProductKind();
            //p.ID = kid;
            //db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
            db.ProductKind.Remove(db.ProductKind.Find(kid));
            return Json(db.SaveChanges(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}