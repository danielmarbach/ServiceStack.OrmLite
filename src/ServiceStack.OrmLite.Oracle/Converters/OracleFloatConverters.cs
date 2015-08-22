﻿using System;
using ServiceStack.OrmLite.Converters;

namespace ServiceStack.OrmLite.Oracle.Converters
{
    public class OracleFloatConverter : FloatConverter
    {
        public override string ColumnDefinition
        {
            get { return "FLOAT"; }
        }

        public override string ToQuotedString(Type fieldType, object value)
        {
            var s = value.ToString();
            if (s.Length > 20) s = s.Substring(0, 20);
            return "'" + s + "'"; // when quoted exception is more clear!
        }
    }

    public class OracleDoubleConverter : DoubleConverter
    {
        public override string ColumnDefinition
        {
            get { return "FLOAT"; }
        }

        public override string ToQuotedString(Type fieldType, object value)
        {
            var s = value.ToString();
            if (s.Length > 20) s = s.Substring(0, 20);
            return "'" + s + "'"; // when quoted exception is more clear!
        }
    }

    public class OracleDecimalConverter : DecimalConverter
    {
        public OracleDecimalConverter() : base(18, 12) {}

        public override string ToQuotedString(Type fieldType, object value)
        {
            var s = value.ToString();
            if (s.Length > 20) s = s.Substring(0, 20);
            return "'" + s + "'"; // when quoted exception is more clear!
        }
    }
}