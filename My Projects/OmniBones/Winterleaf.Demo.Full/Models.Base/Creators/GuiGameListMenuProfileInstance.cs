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
   public class GuiGameListMenuProfileInstance : GuiControlProfileInstance
   {
      public GuiGameListMenuProfileInstance(string _name = "", string _className = "GuiGameListMenuProfile", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Point2I hitAreaLowerRight
      {
         set { Fields["hitAreaLowerRight"] = value.ToString(); }
      }

      public Point2I hitAreaUpperLeft
      {
         set { Fields["hitAreaUpperLeft"] = value.ToString(); }
      }

      public Point2I iconOffset
      {
         set { Fields["iconOffset"] = value.ToString(); }
      }

      public Point2I rowSize
      {
         set { Fields["rowSize"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiGameListMenuProfile(GuiGameListMenuProfileInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiGameListMenuProfile ret = new GuiGameListMenuProfile();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiGameListMenuProfileInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
