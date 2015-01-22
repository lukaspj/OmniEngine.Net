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
   public class MeshRoadInstance : SceneObjectInstance
   {
      public MeshRoadInstance(string _name = "", string _className = "MeshRoad", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeMaterialName bottomMaterial
      {
         set { Fields["bottomMaterial"] = value.ToString(); }
      }

      public float breakAngle
      {
         set { Fields["breakAngle"] = value.ToString(); }
      }

      public String Node
      {
         set { Fields["Node"] = value.ToString(); }
      }

      public TypeMaterialName sideMaterial
      {
         set { Fields["sideMaterial"] = value.ToString(); }
      }

      public float textureLength
      {
         set { Fields["textureLength"] = value.ToString(); }
      }

      public TypeMaterialName topMaterial
      {
         set { Fields["topMaterial"] = value.ToString(); }
      }

      public int widthSubdivisions
      {
         set { Fields["widthSubdivisions"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator MeshRoad(MeshRoadInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         MeshRoad ret = new MeshRoad();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(MeshRoadInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
