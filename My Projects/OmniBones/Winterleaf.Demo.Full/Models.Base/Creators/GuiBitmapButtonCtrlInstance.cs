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
   public class GuiBitmapButtonCtrlInstance : GuiButtonCtrlInstance
   {
      public GuiBitmapButtonCtrlInstance(string _name = "", string _className = "GuiBitmapButtonCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool autoFitExtents
      {
         set { Fields["autoFitExtents"] = value.ToString(); }
      }

      public String bitmap
      {
         set { Fields["bitmap"] = value.ToString(); }
      }

      public TypeGuiBitmapMode bitmapMode
      {
         set { Fields["bitmapMode"] = value.ToString(); }
      }

      public bool useModifiers
      {
         set { Fields["useModifiers"] = value.ToString(); }
      }

      public bool useStates
      {
         set { Fields["useStates"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiBitmapButtonCtrl(GuiBitmapButtonCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiBitmapButtonCtrl ret = new GuiBitmapButtonCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiBitmapButtonCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
