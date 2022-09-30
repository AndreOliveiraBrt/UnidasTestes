using UnidasTestes.Base;

namespace UnidasTestes.Pages
{
    public class LocalizacaoDataPage : BasePage
    {
        public void SetLocalRetirada(string local)
        {
            EscreverID("Nome", local);
        }

        public void SetDataRetirada()
        {
        }

        public void SetHoraRetirada()
        {
        }

        public void SetDataDevolucao()
        {
        }

        public void SetHoraDevolucao()
        {
        }
        public void Alugar()
        {
        }
        public void SelecionarDevolucaoMesmaLoja()
        {
        }
        public void DesmarcarOpcaoDevolucaoMesmaLoja()
        { 
            Ckeckbox("//body/app-root[1]/div[1]/app-home-page[1]/div[1]/div[3]/div[1]/app-masterflow[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/label[2]/span[1]"); 
        }
        public bool ValidarExibicaoCampoDevolucao()
        {
            if (VerificarElemento("//body/app-root[1]/div[1]/app-home-page[1]/div[1]/div[3]/div[1]/app-masterflow[1]/div[1]/div[1]/div[1]/div[1]/div[2]/app-search-stores[1]/div[1]/div[1]/input[1]") != true)
            {
                return false;
            }
            return true;
        }
    }
}
