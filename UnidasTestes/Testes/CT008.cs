using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnidasTestes.Base;
using UnidasTestes.Pages;

namespace UnidasTestes.Testes
{
    [TestClass]
    public class CT008 : BaseTeste
    {
        LocalizacaoDataPage localizacaoDataPage = new LocalizacaoDataPage();

        [TestMethod]
        public void ValidarAcaoOpcaoDevolucaoMesmaLoja()
        {
            localizacaoDataPage.DesmarcarOpcaoDevolucaoMesmaLoja();

            Assert.IsTrue(localizacaoDataPage.ValidarExibicaoCampoDevolucao());

        }
    }
}
