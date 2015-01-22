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
   public class AITurretShapeDataInstance : TurretShapeDataInstance
   {
      public AITurretShapeDataInstance(string _name = "", string _className = "AITurretShapeData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float maxScanDistance
      {
         set { Fields["maxScanDistance"] = value.ToString(); }
      }

      public float maxScanHeading
      {
         set { Fields["maxScanHeading"] = value.ToString(); }
      }

      public float maxScanPitch
      {
         set { Fields["maxScanPitch"] = value.ToString(); }
      }

      public float maxWeaponRange
      {
         set { Fields["maxWeaponRange"] = value.ToString(); }
      }

      public int scanTickFrequency
      {
         set { Fields["scanTickFrequency"] = value.ToString(); }
      }

      public int scanTickFrequencyVariance
      {
         set { Fields["scanTickFrequencyVariance"] = value.ToString(); }
      }

      private FieldWrapper<bool> _stateDirection = new FieldWrapper<bool>();
      public FieldWrapper<bool> stateDirection
      {
         get { _stateDirection.Set(ref mFieldsDictionary, "stateDirection"); return _stateDirection; }
         set { _stateDirection.Set(ref mFieldsDictionary, "stateDirection"); }
      }

      private FieldWrapper<bool> _stateFire = new FieldWrapper<bool>();
      public FieldWrapper<bool> stateFire
      {
         get { _stateFire.Set(ref mFieldsDictionary, "stateFire"); return _stateFire; }
         set { _stateFire.Set(ref mFieldsDictionary, "stateFire"); }
      }

      private FieldWrapper<String> _stateName = new FieldWrapper<String>();
      public FieldWrapper<String> stateName
      {
         get { _stateName.Set(ref mFieldsDictionary, "stateName"); return _stateName; }
         set { _stateName.Set(ref mFieldsDictionary, "stateName"); }
      }

      private FieldWrapper<bool> _stateScaleAnimation = new FieldWrapper<bool>();
      public FieldWrapper<bool> stateScaleAnimation
      {
         get { _stateScaleAnimation.Set(ref mFieldsDictionary, "stateScaleAnimation"); return _stateScaleAnimation; }
         set { _stateScaleAnimation.Set(ref mFieldsDictionary, "stateScaleAnimation"); }
      }

      private FieldWrapper<bool> _stateScan = new FieldWrapper<bool>();
      public FieldWrapper<bool> stateScan
      {
         get { _stateScan.Set(ref mFieldsDictionary, "stateScan"); return _stateScan; }
         set { _stateScan.Set(ref mFieldsDictionary, "stateScan"); }
      }

      private FieldWrapper<String> _stateScript = new FieldWrapper<String>();
      public FieldWrapper<String> stateScript
      {
         get { _stateScript.Set(ref mFieldsDictionary, "stateScript"); return _stateScript; }
         set { _stateScript.Set(ref mFieldsDictionary, "stateScript"); }
      }

      private FieldWrapper<String> _stateSequence = new FieldWrapper<String>();
      public FieldWrapper<String> stateSequence
      {
         get { _stateSequence.Set(ref mFieldsDictionary, "stateSequence"); return _stateSequence; }
         set { _stateSequence.Set(ref mFieldsDictionary, "stateSequence"); }
      }

      private FieldWrapper<float> _stateTimeoutValue = new FieldWrapper<float>();
      public FieldWrapper<float> stateTimeoutValue
      {
         get { _stateTimeoutValue.Set(ref mFieldsDictionary, "stateTimeoutValue"); return _stateTimeoutValue; }
         set { _stateTimeoutValue.Set(ref mFieldsDictionary, "stateTimeoutValue"); }
      }

      private FieldWrapper<String> _stateTransitionOnActivated = new FieldWrapper<String>();
      public FieldWrapper<String> stateTransitionOnActivated
      {
         get { _stateTransitionOnActivated.Set(ref mFieldsDictionary, "stateTransitionOnActivated"); return _stateTransitionOnActivated; }
         set { _stateTransitionOnActivated.Set(ref mFieldsDictionary, "stateTransitionOnActivated"); }
      }

      private FieldWrapper<String> _stateTransitionOnAtRest = new FieldWrapper<String>();
      public FieldWrapper<String> stateTransitionOnAtRest
      {
         get { _stateTransitionOnAtRest.Set(ref mFieldsDictionary, "stateTransitionOnAtRest"); return _stateTransitionOnAtRest; }
         set { _stateTransitionOnAtRest.Set(ref mFieldsDictionary, "stateTransitionOnAtRest"); }
      }

      private FieldWrapper<String> _stateTransitionOnDeactivated = new FieldWrapper<String>();
      public FieldWrapper<String> stateTransitionOnDeactivated
      {
         get { _stateTransitionOnDeactivated.Set(ref mFieldsDictionary, "stateTransitionOnDeactivated"); return _stateTransitionOnDeactivated; }
         set { _stateTransitionOnDeactivated.Set(ref mFieldsDictionary, "stateTransitionOnDeactivated"); }
      }

      private FieldWrapper<String> _stateTransitionOnNoTarget = new FieldWrapper<String>();
      public FieldWrapper<String> stateTransitionOnNoTarget
      {
         get { _stateTransitionOnNoTarget.Set(ref mFieldsDictionary, "stateTransitionOnNoTarget"); return _stateTransitionOnNoTarget; }
         set { _stateTransitionOnNoTarget.Set(ref mFieldsDictionary, "stateTransitionOnNoTarget"); }
      }

      private FieldWrapper<String> _stateTransitionOnNotAtRest = new FieldWrapper<String>();
      public FieldWrapper<String> stateTransitionOnNotAtRest
      {
         get { _stateTransitionOnNotAtRest.Set(ref mFieldsDictionary, "stateTransitionOnNotAtRest"); return _stateTransitionOnNotAtRest; }
         set { _stateTransitionOnNotAtRest.Set(ref mFieldsDictionary, "stateTransitionOnNotAtRest"); }
      }

      private FieldWrapper<String> _stateTransitionOnTarget = new FieldWrapper<String>();
      public FieldWrapper<String> stateTransitionOnTarget
      {
         get { _stateTransitionOnTarget.Set(ref mFieldsDictionary, "stateTransitionOnTarget"); return _stateTransitionOnTarget; }
         set { _stateTransitionOnTarget.Set(ref mFieldsDictionary, "stateTransitionOnTarget"); }
      }

      private FieldWrapper<String> _stateTransitionOnTimeout = new FieldWrapper<String>();
      public FieldWrapper<String> stateTransitionOnTimeout
      {
         get { _stateTransitionOnTimeout.Set(ref mFieldsDictionary, "stateTransitionOnTimeout"); return _stateTransitionOnTimeout; }
         set { _stateTransitionOnTimeout.Set(ref mFieldsDictionary, "stateTransitionOnTimeout"); }
      }

      private FieldWrapper<bool> _stateWaitForTimeout = new FieldWrapper<bool>();
      public FieldWrapper<bool> stateWaitForTimeout
      {
         get { _stateWaitForTimeout.Set(ref mFieldsDictionary, "stateWaitForTimeout"); return _stateWaitForTimeout; }
         set { _stateWaitForTimeout.Set(ref mFieldsDictionary, "stateWaitForTimeout"); }
      }

      public float trackLostTargetTime
      {
         set { Fields["trackLostTargetTime"] = value.ToString(); }
      }

      public float weaponLeadVelocity
      {
         set { Fields["weaponLeadVelocity"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator AITurretShapeData(AITurretShapeDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         AITurretShapeData ret = new AITurretShapeData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(AITurretShapeDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
