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
   public class GuiFilterCtrlInstance : GuiControlInstance
   {
      public GuiFilterCtrlInstance(string _name = "", string _className = "GuiFilterCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int controlPoints
      {
         set { Fields["controlPoints"] = value.ToString(); }
      }

      public VectorFloat filter
      {
         set { Fields["filter"] = value.ToString(); }
      }

      public Point2F identity
      {
         set { Fields["identity"] = value.ToString(); }
      }

      public bool showIdentity
      {
         set { Fields["showIdentity"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiFilterCtrl(GuiFilterCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiFilterCtrl ret = new GuiFilterCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiFilterCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
