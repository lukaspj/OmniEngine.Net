﻿using System.Collections.Generic;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGeneric<TypeSFXStateName>))]
    public class TypeSFXStateName : TypeStringBase<TypeSFXStateName>, iTypeStringBase
        {
        private static volatile List<string> _values;

        public TypeSFXStateName()
            {
            if (Values == null)
                LoadValues();
            }

        public TypeSFXStateName(string value)
            {
            if (Values == null)
                LoadValues();
            this.Value = value;
            }

        public static List<string> Values
            {
            get { return _values; }
            }

        private void LoadValues()
            {
            List<string> values = new List<string>();
            lock (Omni.self.tick)
                {
                ModelBase group = "SFXStateSet";
                for (uint i = 0; i < group.getCount(); i++)
                    {
                    ModelBase o = group.getObject(i);
                    values.Add(o.getName());
                    }
                }
            _values = values;
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a SFX State Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeSFXStateName AsTypeSFXStateName(this string value)
            {
            return new TypeSFXStateName(value);
            }
        }
    }