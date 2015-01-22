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
   public class SFXTrackInstance : SimDataBlockInstance
   {
      public SFXTrackInstance(string _name = "", string _className = "SFXTrack", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeSFXDescriptionName description
      {
         set { Fields["description"] = value.ToString(); }
      }

      private FieldWrapper<TypeSFXParameterName> _parameters = new FieldWrapper<TypeSFXParameterName>();
      public FieldWrapper<TypeSFXParameterName> parameters
      {
         get { _parameters.Set(ref mFieldsDictionary, "parameters"); return _parameters; }
         set { _parameters.Set(ref mFieldsDictionary, "parameters"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SFXTrack(SFXTrackInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SFXTrack ret = new SFXTrack();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SFXTrackInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
