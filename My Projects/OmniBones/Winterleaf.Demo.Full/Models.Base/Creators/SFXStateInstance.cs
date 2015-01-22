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
   public class SFXStateInstance : SimDataBlockInstance
   {
      public SFXStateInstance(string _name = "", string _className = "SFXState", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      private FieldWrapper<TypeSFXStateName> _excludedStates = new FieldWrapper<TypeSFXStateName>();
      public FieldWrapper<TypeSFXStateName> excludedStates
      {
         get { _excludedStates.Set(ref mFieldsDictionary, "excludedStates"); return _excludedStates; }
         set { _excludedStates.Set(ref mFieldsDictionary, "excludedStates"); }
      }

      private FieldWrapper<TypeSFXStateName> _includedStates = new FieldWrapper<TypeSFXStateName>();
      public FieldWrapper<TypeSFXStateName> includedStates
      {
         get { _includedStates.Set(ref mFieldsDictionary, "includedStates"); return _includedStates; }
         set { _includedStates.Set(ref mFieldsDictionary, "includedStates"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SFXState(SFXStateInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SFXState ret = new SFXState();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SFXStateInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
