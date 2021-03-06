﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircuitDiagram.Circuit;
using CircuitDiagram.Plugin;

namespace CircuitDiagram.IO
{
    /// <summary>
    /// Writes a <see cref="CircuitDocument"/> to a stream.
    /// </summary>
    public interface ICircuitWriter
    {
        /// <summary>
        /// Gets the name of the file type associated with this writer.
        /// </summary>
        string FileTypeName { get; }

        /// <summary>
        /// Gets the file extension associated with this writer, including the preceeding period.
        /// </summary>
        string FileTypeExtension { get; }

        /// <summary>
        /// Writes the specified document to the stream.
        /// </summary>
        /// <param name="document">The circuit document to write.</param>
        /// <param name="stream">The stream to write to.</param>
        void WriteCircuit(CircuitDocument document, Stream stream);
    }
}
