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
   public class SceneObjectInstance : NetObjectInstance
   {
      public SceneObjectInstance(string _name = "", string _className = "SceneObject", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool isRenderEnabled
      {
         set { Fields["isRenderEnabled"] = value.ToString(); }
      }

      public bool isSelectionEnabled
      {
         set { Fields["isSelectionEnabled"] = value.ToString(); }
      }

      public int mountNode
      {
         set { Fields["mountNode"] = value.ToString(); }
      }

      public int mountPID
      {
         set { Fields["mountPID"] = value.ToString(); }
      }

      public MatrixPosition mountPos
      {
         set { Fields["mountPos"] = value.ToString(); }
      }

      public AngAxisF mountRot
      {
         set { Fields["mountRot"] = value.ToString(); }
      }

      public MatrixPosition position
      {
         set { Fields["position"] = value.ToString(); }
      }

      public AngAxisF rotation
      {
         set { Fields["rotation"] = value.ToString(); }
      }

      public Point3F scale
      {
         set { Fields["scale"] = value.ToString(); }
      }

      public bool TickCounterNotifyServer
      {
         set { Fields["TickCounterNotifyServer"] = value.ToString(); }
      }

      public bool TickNotifyAfter
      {
         set { Fields["TickNotifyAfter"] = value.ToString(); }
      }

      public bool TickNotifyBefore
      {
         set { Fields["TickNotifyBefore"] = value.ToString(); }
      }

      public bool TickNotifyClient
      {
         set { Fields["TickNotifyClient"] = value.ToString(); }
      }

      public bool TickNotifyServer
      {
         set { Fields["TickNotifyServer"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SceneObject(SceneObjectInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SceneObject ret = new SceneObject();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SceneObjectInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
