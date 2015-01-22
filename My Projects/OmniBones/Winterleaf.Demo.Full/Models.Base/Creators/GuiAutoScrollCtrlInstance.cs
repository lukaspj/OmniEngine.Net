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
   public class GuiAutoScrollCtrlInstance : GuiTickCtrlInstance
   {
      public GuiAutoScrollCtrlInstance(string _name = "", string _className = "GuiAutoScrollCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int childBorder
      {
         set { Fields["childBorder"] = value.ToString(); }
      }

      public bool isLooping
      {
         set { Fields["isLooping"] = value.ToString(); }
      }

      public float resetDelay
      {
         set { Fields["resetDelay"] = value.ToString(); }
      }

      public TypeGuiAutoScrollDirection scrollDirection
      {
         set { Fields["scrollDirection"] = value.ToString(); }
      }

      public bool scrollOutOfSight
      {
         set { Fields["scrollOutOfSight"] = value.ToString(); }
      }

      public float scrollSpeed
      {
         set { Fields["scrollSpeed"] = value.ToString(); }
      }

      public float startDelay
      {
         set { Fields["startDelay"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiAutoScrollCtrl(GuiAutoScrollCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiAutoScrollCtrl ret = new GuiAutoScrollCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiAutoScrollCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
