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
   public class LightningDataInstance : GameBaseDataInstance
   {
      public LightningDataInstance(string _name = "", string _className = "LightningData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public SFXTrack strikeSound
      {
         set { Fields["strikeSound"] = value.ToString(); }
      }

      private FieldWrapper<String> _strikeTextures = new FieldWrapper<String>();
      public FieldWrapper<String> strikeTextures
      {
         get { _strikeTextures.Set(ref mFieldsDictionary, "strikeTextures"); return _strikeTextures; }
         set { _strikeTextures.Set(ref mFieldsDictionary, "strikeTextures"); }
      }

      private FieldWrapper<SFXTrack> _thunderSounds = new FieldWrapper<SFXTrack>();
      public FieldWrapper<SFXTrack> thunderSounds
      {
         get { _thunderSounds.Set(ref mFieldsDictionary, "thunderSounds"); return _thunderSounds; }
         set { _thunderSounds.Set(ref mFieldsDictionary, "thunderSounds"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator LightningData(LightningDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         LightningData ret = new LightningData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(LightningDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
