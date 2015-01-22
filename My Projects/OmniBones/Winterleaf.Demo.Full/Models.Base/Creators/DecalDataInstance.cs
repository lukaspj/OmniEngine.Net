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
   public class DecalDataInstance : SimDataBlockInstance
   {
      public DecalDataInstance(string _name = "", string _className = "DecalData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float clippingAngle
      {
         set { Fields["clippingAngle"] = value.ToString(); }
      }

      public float fadeEndPixelSize
      {
         set { Fields["fadeEndPixelSize"] = value.ToString(); }
      }

      public float fadeStartPixelSize
      {
         set { Fields["fadeStartPixelSize"] = value.ToString(); }
      }

      public int fadeTime
      {
         set { Fields["fadeTime"] = value.ToString(); }
      }

      public int frame
      {
         set { Fields["frame"] = value.ToString(); }
      }

      public int lifeSpan
      {
         set { Fields["lifeSpan"] = value.ToString(); }
      }

      public TypeMaterialName material
      {
         set { Fields["material"] = value.ToString(); }
      }

      public bool randomize
      {
         set { Fields["randomize"] = value.ToString(); }
      }

      public sbyte renderPriority
      {
         set { Fields["renderPriority"] = value.ToString(); }
      }

      public float size
      {
         set { Fields["size"] = value.ToString(); }
      }

      public int texCols
      {
         set { Fields["texCols"] = value.ToString(); }
      }

      public int texRows
      {
         set { Fields["texRows"] = value.ToString(); }
      }

      public int textureCoordCount
      {
         set { Fields["textureCoordCount"] = value.ToString(); }
      }

      private FieldWrapper<RectF> _textureCoords = new FieldWrapper<RectF>();
      public FieldWrapper<RectF> textureCoords
      {
         get { _textureCoords.Set(ref mFieldsDictionary, "textureCoords"); return _textureCoords; }
         set { _textureCoords.Set(ref mFieldsDictionary, "textureCoords"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator DecalData(DecalDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         DecalData ret = new DecalData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(DecalDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
