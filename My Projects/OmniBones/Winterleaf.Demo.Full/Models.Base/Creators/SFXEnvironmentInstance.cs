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
   public class SFXEnvironmentInstance : SimDataBlockInstance
   {
      public SFXEnvironmentInstance(string _name = "", string _className = "SFXEnvironment", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float airAbsorptionHF
      {
         set { Fields["airAbsorptionHF"] = value.ToString(); }
      }

      public float decayHFRatio
      {
         set { Fields["decayHFRatio"] = value.ToString(); }
      }

      public float decayLFRatio
      {
         set { Fields["decayLFRatio"] = value.ToString(); }
      }

      public float decayTime
      {
         set { Fields["decayTime"] = value.ToString(); }
      }

      public float density
      {
         set { Fields["density"] = value.ToString(); }
      }

      public float diffusion
      {
         set { Fields["diffusion"] = value.ToString(); }
      }

      public float echoDepth
      {
         set { Fields["echoDepth"] = value.ToString(); }
      }

      public float echoTime
      {
         set { Fields["echoTime"] = value.ToString(); }
      }

      public float envDiffusion
      {
         set { Fields["envDiffusion"] = value.ToString(); }
      }

      public float envSize
      {
         set { Fields["envSize"] = value.ToString(); }
      }

      public int flags
      {
         set { Fields["flags"] = value.ToString(); }
      }

      public float HFReference
      {
         set { Fields["HFReference"] = value.ToString(); }
      }

      public float LFReference
      {
         set { Fields["LFReference"] = value.ToString(); }
      }

      public float modulationDepth
      {
         set { Fields["modulationDepth"] = value.ToString(); }
      }

      public float modulationTime
      {
         set { Fields["modulationTime"] = value.ToString(); }
      }

      public int reflections
      {
         set { Fields["reflections"] = value.ToString(); }
      }

      public float reflectionsDelay
      {
         set { Fields["reflectionsDelay"] = value.ToString(); }
      }

      private FieldWrapper<float> _reflectionsPan = new FieldWrapper<float>();
      public FieldWrapper<float> reflectionsPan
      {
         get { _reflectionsPan.Set(ref mFieldsDictionary, "reflectionsPan"); return _reflectionsPan; }
         set { _reflectionsPan.Set(ref mFieldsDictionary, "reflectionsPan"); }
      }

      public int reverb
      {
         set { Fields["reverb"] = value.ToString(); }
      }

      public float reverbDelay
      {
         set { Fields["reverbDelay"] = value.ToString(); }
      }

      private FieldWrapper<float> _reverbPan = new FieldWrapper<float>();
      public FieldWrapper<float> reverbPan
      {
         get { _reverbPan.Set(ref mFieldsDictionary, "reverbPan"); return _reverbPan; }
         set { _reverbPan.Set(ref mFieldsDictionary, "reverbPan"); }
      }

      public int room
      {
         set { Fields["room"] = value.ToString(); }
      }

      public int roomHF
      {
         set { Fields["roomHF"] = value.ToString(); }
      }

      public int roomLF
      {
         set { Fields["roomLF"] = value.ToString(); }
      }

      public float roomRolloffFactor
      {
         set { Fields["roomRolloffFactor"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SFXEnvironment(SFXEnvironmentInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SFXEnvironment ret = new SFXEnvironment();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SFXEnvironmentInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
