﻿using SharpPdb.Windows.Utility;

namespace SharpPdb.Windows.SymbolRecords
{
    /// <summary>
    /// Represents end of the symbol group. Usually it is being used to denote end of the children list.
    /// </summary>
    public class EndSymbol : SymbolRecord
    {
        /// <summary>
        /// Array of <see cref="SymbolRecordKind"/> that this class can read.
        /// </summary>
        public static readonly SymbolRecordKind[] Kinds = new SymbolRecordKind[]
        {
            SymbolRecordKind.S_END,
        };

        /// <summary>
        /// Reads <see cref="EndSymbol"/> from the stream.
        /// </summary>
        /// <param name="reader">Stream binary reader.</param>
        /// <param name="kind">Symbol record kind.</param>
        public static EndSymbol Read(IBinaryReader reader, SymbolRecordKind kind)
        {
            return new EndSymbol
            {
                Kind = kind,
            };
        }
    }
}