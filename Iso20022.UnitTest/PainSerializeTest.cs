using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Test
{
    public class PainSerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.001.003.01.xml")]
        public void Pain_001_003_01(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Sepa.Models.Entities.XsdSchemas.Pain_001_003_01.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Sepa.Models.Entities.XsdSchemas.Pain_001_003_01.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.002.001.03_1.xml")]
        [InlineData("./Resources/Pain/pain.002.001.03_2.xml")]
        public void Pain_002_001_03(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Sepa.Models.Entities.XsdSchemas.Pain_002_001_03.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Sepa.Models.Entities.XsdSchemas.Pain_002_001_03.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.008.001.02.xml")]
        public void Pain_008_001_02(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Sepa.Models.Entities.XsdSchemas.Pain_008_001_02.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Sepa.Models.Entities.XsdSchemas.Pain_008_001_02.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}