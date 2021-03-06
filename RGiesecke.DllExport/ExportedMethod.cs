﻿// [Decompiled] Assembly: RGiesecke.DllExport, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// Author of original assembly (MIT-License): Robert Giesecke
// Use Readme & LICENSE files for details.

namespace RGiesecke.DllExport
{
    public sealed class ExportedMethod: ExportInfo
    {
        private readonly ExportedClass _ExportedClass;

        public string Name
        {
            get {
                return this.MemberName;
            }
        }

        public ExportedClass ExportedClass
        {
            get {
                return this._ExportedClass;
            }
        }

        public string MemberName
        {
            get;
            set;
        }

        public int VTableOffset
        {
            get;
            set;
        }

        public override string ExportName
        {
            get {
                return base.ExportName ?? this.Name;
            }

            set {
                base.ExportName = value;
            }
        }

        public ExportedMethod(ExportedClass exportedClass)
        {
            this._ExportedClass = exportedClass;
        }
    }
}
