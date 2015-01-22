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
   public class SFXEmitterInstance : SceneObjectInstance
   {
      public SFXEmitterInstance(string _name = "", string _className = "SFXEmitter", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int coneInsideAngle
      {
         set { Fields["coneInsideAngle"] = value.ToString(); }
      }

      public int coneOutsideAngle
      {
         set { Fields["coneOutsideAngle"] = value.ToString(); }
      }

      public float coneOutsideVolume
      {
         set { Fields["coneOutsideVolume"] = value.ToString(); }
      }

      public float fadeInTime
      {
         set { Fields["fadeInTime"] = value.ToString(); }
      }

      public float fadeOutTime
      {
         set { Fields["fadeOutTime"] = value.ToString(); }
      }

      public String fileName
      {
         set { Fields["fileName"] = value.ToString(); }
      }

      public bool is3D
      {
         set { Fields["is3D"] = value.ToString(); }
      }

      public bool isLooping
      {
         set { Fields["isLooping"] = value.ToString(); }
      }

      public bool isStreaming
      {
         set { Fields["isStreaming"] = value.ToString(); }
      }

      public float maxDistance
      {
         set { Fields["maxDistance"] = value.ToString(); }
      }

      public float pitch
      {
         set { Fields["pitch"] = value.ToString(); }
      }

      public bool playOnAdd
      {
         set { Fields["playOnAdd"] = value.ToString(); }
      }

      public float referenceDistance
      {
         set { Fields["referenceDistance"] = value.ToString(); }
      }

      public Point3F scatterDistance
      {
         set { Fields["scatterDistance"] = value.ToString(); }
      }

      public TypeSFXSourceName sourceGroup
      {
         set { Fields["sourceGroup"] = value.ToString(); }
      }

      public TypeSFXTrackName track
      {
         set { Fields["track"] = value.ToString(); }
      }

      public bool useTrackDescriptionOnly
      {
         set { Fields["useTrackDescriptionOnly"] = value.ToString(); }
      }

      public float volume
      {
         set { Fields["volume"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SFXEmitter(SFXEmitterInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SFXEmitter ret = new SFXEmitter();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SFXEmitterInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
