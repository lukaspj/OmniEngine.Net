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
   public class SFXAmbienceInstance : SimDataBlockInstance
   {
      public SFXAmbienceInstance(string _name = "", string _className = "SFXAmbience", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float dopplerFactor
      {
         set { Fields["dopplerFactor"] = value.ToString(); }
      }

      public TypeSFXEnvironmentName environment
      {
         set { Fields["environment"] = value.ToString(); }
      }

      public float rolloffFactor
      {
         set { Fields["rolloffFactor"] = value.ToString(); }
      }

      public TypeSFXTrackName soundTrack
      {
         set { Fields["soundTrack"] = value.ToString(); }
      }

      private FieldWrapper<TypeSFXStateName> _states = new FieldWrapper<TypeSFXStateName>();
      public FieldWrapper<TypeSFXStateName> states
      {
         get { _states.Set(ref mFieldsDictionary, "states"); return _states; }
         set { _states.Set(ref mFieldsDictionary, "states"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SFXAmbience(SFXAmbienceInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SFXAmbience ret = new SFXAmbience();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SFXAmbienceInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
