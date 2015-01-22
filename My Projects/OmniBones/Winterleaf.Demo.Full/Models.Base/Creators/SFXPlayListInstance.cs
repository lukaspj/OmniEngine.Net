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
   public class SFXPlayListInstance : SFXTrackInstance
   {
      public SFXPlayListInstance(string _name = "", string _className = "SFXPlayList", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      private FieldWrapper<float> _delayTimeIn = new FieldWrapper<float>();
      public FieldWrapper<float> delayTimeIn
      {
         get { _delayTimeIn.Set(ref mFieldsDictionary, "delayTimeIn"); return _delayTimeIn; }
         set { _delayTimeIn.Set(ref mFieldsDictionary, "delayTimeIn"); }
      }

      private FieldWrapper<Point2F> _delayTimeInVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> delayTimeInVariance
      {
         get { _delayTimeInVariance.Set(ref mFieldsDictionary, "delayTimeInVariance"); return _delayTimeInVariance; }
         set { _delayTimeInVariance.Set(ref mFieldsDictionary, "delayTimeInVariance"); }
      }

      private FieldWrapper<float> _delayTimeOut = new FieldWrapper<float>();
      public FieldWrapper<float> delayTimeOut
      {
         get { _delayTimeOut.Set(ref mFieldsDictionary, "delayTimeOut"); return _delayTimeOut; }
         set { _delayTimeOut.Set(ref mFieldsDictionary, "delayTimeOut"); }
      }

      private FieldWrapper<Point2F> _delayTimeOutVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> delayTimeOutVariance
      {
         get { _delayTimeOutVariance.Set(ref mFieldsDictionary, "delayTimeOutVariance"); return _delayTimeOutVariance; }
         set { _delayTimeOutVariance.Set(ref mFieldsDictionary, "delayTimeOutVariance"); }
      }

      private FieldWrapper<float> _fadeTimeIn = new FieldWrapper<float>();
      public FieldWrapper<float> fadeTimeIn
      {
         get { _fadeTimeIn.Set(ref mFieldsDictionary, "fadeTimeIn"); return _fadeTimeIn; }
         set { _fadeTimeIn.Set(ref mFieldsDictionary, "fadeTimeIn"); }
      }

      private FieldWrapper<Point2F> _fadeTimeInVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> fadeTimeInVariance
      {
         get { _fadeTimeInVariance.Set(ref mFieldsDictionary, "fadeTimeInVariance"); return _fadeTimeInVariance; }
         set { _fadeTimeInVariance.Set(ref mFieldsDictionary, "fadeTimeInVariance"); }
      }

      private FieldWrapper<float> _fadeTimeOut = new FieldWrapper<float>();
      public FieldWrapper<float> fadeTimeOut
      {
         get { _fadeTimeOut.Set(ref mFieldsDictionary, "fadeTimeOut"); return _fadeTimeOut; }
         set { _fadeTimeOut.Set(ref mFieldsDictionary, "fadeTimeOut"); }
      }

      private FieldWrapper<Point2F> _fadeTimeOutVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> fadeTimeOutVariance
      {
         get { _fadeTimeOutVariance.Set(ref mFieldsDictionary, "fadeTimeOutVariance"); return _fadeTimeOutVariance; }
         set { _fadeTimeOutVariance.Set(ref mFieldsDictionary, "fadeTimeOutVariance"); }
      }

      public TypeSFXPlayListLoopMode loopMode
      {
         set { Fields["loopMode"] = value.ToString(); }
      }

      private FieldWrapper<float> _maxDistance = new FieldWrapper<float>();
      public FieldWrapper<float> maxDistance
      {
         get { _maxDistance.Set(ref mFieldsDictionary, "maxDistance"); return _maxDistance; }
         set { _maxDistance.Set(ref mFieldsDictionary, "maxDistance"); }
      }

      private FieldWrapper<Point2F> _maxDistanceVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> maxDistanceVariance
      {
         get { _maxDistanceVariance.Set(ref mFieldsDictionary, "maxDistanceVariance"); return _maxDistanceVariance; }
         set { _maxDistanceVariance.Set(ref mFieldsDictionary, "maxDistanceVariance"); }
      }

      public int numSlotsToPlay
      {
         set { Fields["numSlotsToPlay"] = value.ToString(); }
      }

      private FieldWrapper<float> _pitchScale = new FieldWrapper<float>();
      public FieldWrapper<float> pitchScale
      {
         get { _pitchScale.Set(ref mFieldsDictionary, "pitchScale"); return _pitchScale; }
         set { _pitchScale.Set(ref mFieldsDictionary, "pitchScale"); }
      }

      private FieldWrapper<Point2F> _pitchScaleVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> pitchScaleVariance
      {
         get { _pitchScaleVariance.Set(ref mFieldsDictionary, "pitchScaleVariance"); return _pitchScaleVariance; }
         set { _pitchScaleVariance.Set(ref mFieldsDictionary, "pitchScaleVariance"); }
      }

      public TypeSFXPlayListRandomMode random
      {
         set { Fields["random"] = value.ToString(); }
      }

      private FieldWrapper<float> _referenceDistance = new FieldWrapper<float>();
      public FieldWrapper<float> referenceDistance
      {
         get { _referenceDistance.Set(ref mFieldsDictionary, "referenceDistance"); return _referenceDistance; }
         set { _referenceDistance.Set(ref mFieldsDictionary, "referenceDistance"); }
      }

      private FieldWrapper<Point2F> _referenceDistanceVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> referenceDistanceVariance
      {
         get { _referenceDistanceVariance.Set(ref mFieldsDictionary, "referenceDistanceVariance"); return _referenceDistanceVariance; }
         set { _referenceDistanceVariance.Set(ref mFieldsDictionary, "referenceDistanceVariance"); }
      }

      private FieldWrapper<int> _repeatCount = new FieldWrapper<int>();
      public FieldWrapper<int> repeatCount
      {
         get { _repeatCount.Set(ref mFieldsDictionary, "repeatCount"); return _repeatCount; }
         set { _repeatCount.Set(ref mFieldsDictionary, "repeatCount"); }
      }

      private FieldWrapper<TypeSFXPlayListReplayMode> _replay = new FieldWrapper<TypeSFXPlayListReplayMode>();
      public FieldWrapper<TypeSFXPlayListReplayMode> replay
      {
         get { _replay.Set(ref mFieldsDictionary, "replay"); return _replay; }
         set { _replay.Set(ref mFieldsDictionary, "replay"); }
      }

      private FieldWrapper<TypeSFXStateName> _state = new FieldWrapper<TypeSFXStateName>();
      public FieldWrapper<TypeSFXStateName> state
      {
         get { _state.Set(ref mFieldsDictionary, "state"); return _state; }
         set { _state.Set(ref mFieldsDictionary, "state"); }
      }

      private FieldWrapper<TypeSFXPlayListStateMode> _stateMode = new FieldWrapper<TypeSFXPlayListStateMode>();
      public FieldWrapper<TypeSFXPlayListStateMode> stateMode
      {
         get { _stateMode.Set(ref mFieldsDictionary, "stateMode"); return _stateMode; }
         set { _stateMode.Set(ref mFieldsDictionary, "stateMode"); }
      }

      public bool trace
      {
         set { Fields["trace"] = value.ToString(); }
      }

      private FieldWrapper<TypeSFXTrackName> _track = new FieldWrapper<TypeSFXTrackName>();
      public FieldWrapper<TypeSFXTrackName> track
      {
         get { _track.Set(ref mFieldsDictionary, "track"); return _track; }
         set { _track.Set(ref mFieldsDictionary, "track"); }
      }

      private FieldWrapper<TypeSFXPlayListTransitionMode> _transitionIn = new FieldWrapper<TypeSFXPlayListTransitionMode>();
      public FieldWrapper<TypeSFXPlayListTransitionMode> transitionIn
      {
         get { _transitionIn.Set(ref mFieldsDictionary, "transitionIn"); return _transitionIn; }
         set { _transitionIn.Set(ref mFieldsDictionary, "transitionIn"); }
      }

      private FieldWrapper<TypeSFXPlayListTransitionMode> _transitionOut = new FieldWrapper<TypeSFXPlayListTransitionMode>();
      public FieldWrapper<TypeSFXPlayListTransitionMode> transitionOut
      {
         get { _transitionOut.Set(ref mFieldsDictionary, "transitionOut"); return _transitionOut; }
         set { _transitionOut.Set(ref mFieldsDictionary, "transitionOut"); }
      }

      private FieldWrapper<float> _volumeScale = new FieldWrapper<float>();
      public FieldWrapper<float> volumeScale
      {
         get { _volumeScale.Set(ref mFieldsDictionary, "volumeScale"); return _volumeScale; }
         set { _volumeScale.Set(ref mFieldsDictionary, "volumeScale"); }
      }

      private FieldWrapper<Point2F> _volumeScaleVariance = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> volumeScaleVariance
      {
         get { _volumeScaleVariance.Set(ref mFieldsDictionary, "volumeScaleVariance"); return _volumeScaleVariance; }
         set { _volumeScaleVariance.Set(ref mFieldsDictionary, "volumeScaleVariance"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SFXPlayList(SFXPlayListInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SFXPlayList ret = new SFXPlayList();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SFXPlayListInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
