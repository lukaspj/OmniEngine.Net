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
   public class GuiTreeViewCtrlInstance : GuiArrayCtrlInstance
   {
      public GuiTreeViewCtrlInstance(string _name = "", string _className = "GuiTreeViewCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool canRenameObjects
      {
         set { Fields["canRenameObjects"] = value.ToString(); }
      }

      public bool clearAllOnSingleSelection
      {
         set { Fields["clearAllOnSingleSelection"] = value.ToString(); }
      }

      public bool compareToObjectID
      {
         set { Fields["compareToObjectID"] = value.ToString(); }
      }

      public bool deleteObjectAllowed
      {
         set { Fields["deleteObjectAllowed"] = value.ToString(); }
      }

      public bool destroyTreeOnSleep
      {
         set { Fields["destroyTreeOnSleep"] = value.ToString(); }
      }

      public bool dragToItemAllowed
      {
         set { Fields["dragToItemAllowed"] = value.ToString(); }
      }

      public bool fullRowSelect
      {
         set { Fields["fullRowSelect"] = value.ToString(); }
      }

      public int itemHeight
      {
         set { Fields["itemHeight"] = value.ToString(); }
      }

      public bool mouseDragging
      {
         set { Fields["mouseDragging"] = value.ToString(); }
      }

      public bool multipleSelections
      {
         set { Fields["multipleSelections"] = value.ToString(); }
      }

      public bool renameInternal
      {
         set { Fields["renameInternal"] = value.ToString(); }
      }

      public bool showClassNameForUnnamedObjects
      {
         set { Fields["showClassNameForUnnamedObjects"] = value.ToString(); }
      }

      public bool showClassNames
      {
         set { Fields["showClassNames"] = value.ToString(); }
      }

      public bool showInternalNames
      {
         set { Fields["showInternalNames"] = value.ToString(); }
      }

      public bool showObjectIds
      {
         set { Fields["showObjectIds"] = value.ToString(); }
      }

      public bool showObjectNames
      {
         set { Fields["showObjectNames"] = value.ToString(); }
      }

      public bool showRoot
      {
         set { Fields["showRoot"] = value.ToString(); }
      }

      public int tabSize
      {
         set { Fields["tabSize"] = value.ToString(); }
      }

      public int textOffset
      {
         set { Fields["textOffset"] = value.ToString(); }
      }

      public bool tooltipOnWidthOnly
      {
         set { Fields["tooltipOnWidthOnly"] = value.ToString(); }
      }

      public bool useInspectorTooltips
      {
         set { Fields["useInspectorTooltips"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiTreeViewCtrl(GuiTreeViewCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiTreeViewCtrl ret = new GuiTreeViewCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiTreeViewCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
