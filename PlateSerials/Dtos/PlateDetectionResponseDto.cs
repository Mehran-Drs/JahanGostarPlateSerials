using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlateSerials.Dtos
{
    public class PlateDetectionResponseDto
    {
        [JsonPropertyName("output")]
        public int DetectionId { get; set; }

        [JsonPropertyName("result")]
        public List<PlateDetectionResultResponeDto> Result { get; set; }

    }
    public class PlateDetectionResultResponeDto
    {
        [JsonPropertyName("output")]
        public PlateDetectionOutputResponseDto Output { get; set; }

        [JsonPropertyName("metaDate")]
        public string MetaData { get; set; }
    }
    public class PlateDetectionOutputResponseDto
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("score")]
        public string Score { get; set; }
    }
}
