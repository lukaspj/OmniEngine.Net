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
   public class ParticleEmitterNodeInstance : GameBaseInstance
   {
      public ParticleEmitterNodeInstance(string _name = "", string _className = "ParticleEmitterNode", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool active
      {
         set { Fields["active"] = value.ToString(); }
      }

      public ParticleEmitterData emitter
      {
         set { Fields["emitter"] = value.ToString(); }
      }

      public float velocity
      {
         set { Fields["velocity"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ParticleEmitterNode(ParticleEmitterNodeInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ParticleEmitterNode ret = new ParticleEmitterNode();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ParticleEmitterNodeInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
