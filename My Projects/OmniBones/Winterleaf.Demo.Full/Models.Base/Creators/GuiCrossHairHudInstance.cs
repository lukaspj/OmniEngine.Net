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
   public class GuiCrossHairHudInstance : GuiBitmapCtrlInstance
   {
      public GuiCrossHairHudInstance(string _name = "", string _className = "GuiCrossHairHud", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorF damageFillColor
      {
         set { Fields["damageFillColor"] = value.ToString(); }
      }

      public ColorF damageFrameColor
      {
         set { Fields["damageFrameColor"] = value.ToString(); }
      }

      public Point2I damageOffset
      {
         set { Fields["damageOffset"] = value.ToString(); }
      }

      public Point2I damageRect
      {
         set { Fields["damageRect"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiCrossHairHud(GuiCrossHairHudInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiCrossHairHud ret = new GuiCrossHairHud();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiCrossHairHudInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
