using System;
using System.Collections.Generic;
using System.Linq;
using EasyToolkit.OdinSerializer;
using EasyToolkit.TileWorldPro;

[assembly: RegisterFormatter(typeof(ChunkFormatter))]
namespace EasyToolkit.TileWorldPro
{
    public class ChunkFormatter : MinimalBaseFormatter<Chunk>
    {
        private static readonly Serializer<ChunkArea> ChunkAreaSerializer = Serializer.Get<ChunkArea>();
        private static readonly Serializer<List<Chunk.TerrainSection>> ChunkTerrainSectionsSerializer = Serializer.Get<List<Chunk.TerrainSection>>();

        protected override void Read(ref Chunk value, IDataReader reader)
        {
            var area = ChunkAreaSerializer.ReadValue(reader);
            var terrainSections = ChunkTerrainSectionsSerializer.ReadValue(reader);
            value = new Chunk(area, terrainSections);
        }

        protected override void Write(ref Chunk value, IDataWriter writer)
        {
            ChunkAreaSerializer.WriteValue(value.Area, writer);
            ChunkTerrainSectionsSerializer.WriteValue(value.TerrainSections.ToList(), writer);
        }
    }
}