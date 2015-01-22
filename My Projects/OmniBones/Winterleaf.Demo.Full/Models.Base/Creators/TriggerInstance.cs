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
   public class TriggerInstance : GameBaseInstance
   {
      public TriggerInstance(string _name = "", string _className = "Trigger", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String enterCommand
      {
         set { Fields["enterCommand"] = value.ToString(); }
      }

      public String leaveCommand
      {
         set { Fields["leaveCommand"] = value.ToString(); }
      }

      public Polyhedron polyhedron
      {
         set { Fields["polyhedron"] = value.ToString(); }
      }

      public String tickCommand
      {
         set { Fields["tickCommand"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Trigger(TriggerInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Trigger ret = new Trigger();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TriggerInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
