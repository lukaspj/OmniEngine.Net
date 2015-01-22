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
   public class GuiSpeedometerHudInstance : GuiBitmapCtrlInstance
   {
      public GuiSpeedometerHudInstance(string _name = "", string _className = "GuiSpeedometerHud", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Point2F center
      {
         set { Fields["center"] = value.ToString(); }
      }

      public ColorF color
      {
         set { Fields["color"] = value.ToString(); }
      }

      public float length
      {
         set { Fields["length"] = value.ToString(); }
      }

      public float maxAngle
      {
         set { Fields["maxAngle"] = value.ToString(); }
      }

      public float maxSpeed
      {
         set { Fields["maxSpeed"] = value.ToString(); }
      }

      public float minAngle
      {
         set { Fields["minAngle"] = value.ToString(); }
      }

      public float tail
      {
         set { Fields["tail"] = value.ToString(); }
      }

      public float width
      {
         set { Fields["width"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiSpeedometerHud(GuiSpeedometerHudInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiSpeedometerHud ret = new GuiSpeedometerHud();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiSpeedometerHudInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
