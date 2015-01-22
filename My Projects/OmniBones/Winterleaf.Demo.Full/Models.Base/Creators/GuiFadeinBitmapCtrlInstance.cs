using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.Base.Creators
{
   /// <summary>
   /// 
   /// </summary>
   public class GuiFadeinBitmapCtrlInstance : GuiBitmapCtrlInstance
   {
      public GuiFadeinBitmapCtrlInstance(string _name = "", string _className = "GuiFadeinBitmapCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool done
      {
         set { Fields["done"] = value.ToString(); }
      }

      public ColorF fadeColor
      {
         set { Fields["fadeColor"] = value.ToString(); }
      }

      public EaseF fadeInEase
      {
         set { Fields["fadeInEase"] = value.ToString(); }
      }

      public int fadeInTime
      {
         set { Fields["fadeInTime"] = value.ToString(); }
      }

      public EaseF fadeOutEase
      {
         set { Fields["fadeOutEase"] = value.ToString(); }
      }

      public int fadeOutTime
      {
         set { Fields["fadeOutTime"] = value.ToString(); }
      }

      public int waitTime
      {
         set { Fields["waitTime"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiFadeinBitmapCtrl(GuiFadeinBitmapCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiFadeinBitmapCtrl ret = new GuiFadeinBitmapCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiFadeinBitmapCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
