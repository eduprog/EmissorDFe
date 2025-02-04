﻿using System;
using FusionCore.DFe.XmlCte;

namespace FusionCore.DFe.WsdlCte.Homologacao.Helper
{
    public class UrlHelper
    {
        public static UrlServicoSefaz ObterUrl(FusionEstadoUFCTe estado, FusionTipoAmbienteCTe ambiente, FusionTipoEmissaoCTe tipoEmissao)
        {
            switch (ambiente)
            {
                case FusionTipoAmbienteCTe.Homologacao:
                    if (tipoEmissao == FusionTipoEmissaoCTe.AutorizacaoSvcRs)
                    {
                        return UrlHomologacaoSvrs();
                    }

                    if (tipoEmissao == FusionTipoEmissaoCTe.AutorizacaoSvcSp)
                    {
                        return UrlHomologacaoSvcsp();
                    }


                    return UrlHomologacao(estado);
                case FusionTipoAmbienteCTe.Producao:
                    if (tipoEmissao == FusionTipoEmissaoCTe.AutorizacaoSvcRs)
                    {
                        return UrlProducaoSvrs();
                    }

                    if (tipoEmissao == FusionTipoEmissaoCTe.AutorizacaoSvcSp)
                    {
                        return UrlProducaoSvcsp();
                    }

                    return UrlProducao(estado);
            }

            throw new InvalidOperationException("Tipo ambiente inválido");
        }

        private static UrlServicoSefaz UrlProducaoSvcsp()
        {
            return new UrlServicoSefaz
            {
                CteRecepcao = @"https://nfe.fazenda.sp.gov.br/cteWEB/services/cteRecepcao.asmx",
                CteRetRecepcao = @"https://nfe.fazenda.sp.gov.br/cteWEB/services/CteRetRecepcao.asmx",
                CteConsultaProtocolo = @"https://nfe.fazenda.sp.gov.br/cteWEB/services/CteConsulta.asmx",
                CteStatusServico = @"https://nfe.fazenda.sp.gov.br/cteWEB/services/CteStatusServico.asmx",
                CteRecepcaoEvento = @"https://nfe.fazenda.sp.gov.br/cteWEB/services/CteRecepcaoEvento.asmx",
                QrCode = @"https://nfe.fazenda.sp.gov.br/CTeConsulta/qrCode",
                ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
            };
        }

        private static UrlServicoSefaz UrlProducaoSvrs()
        {
            return new UrlServicoSefaz
            {
                CteRecepcao = @"https://cte.svrs.rs.gov.br/ws/cterecepcao/CTeRecepcao.asmx",
                CteRetRecepcao = @"https://cte.svrs.rs.gov.br/ws/cteretrecepcao/CTeRetRecepcao.asmx",
                CteInutilizacao = @"https://cte.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                CteConsultaProtocolo = @"https://cte.svrs.rs.gov.br/ws/cteconsulta/CTeConsulta.asmx",
                CteStatusServico = @"https://cte.svrs.rs.gov.br/ws/ctestatusservico/CTeStatusServico.asmx",
                CteRecepcaoEvento = @"https://cte.svrs.rs.gov.br/ws/cterecepcaoevento/CTeRecepcaoEvento.asmx",
                QrCode = @"http://dfe-portal.svrs.rs.gov.br/cte/QRCode",
                ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
            };
        }

        private static UrlServicoSefaz UrlHomologacaoSvcsp()
        {
            return new UrlServicoSefaz
            {
                CteRecepcaoEvento = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRecepcaoEvento.asmx",
                CteRecepcao = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRecepcao.asmx",
                CteRetRecepcao = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRetRecepcao.asmx",
                CteConsultaProtocolo = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteConsulta.asmx",
                CteStatusServico = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteStatusServico.asmx",
                QrCode = @"https://homologacao.nfe.fazenda.sp.gov.br/CTeConsulta/qrCode",
                ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
            };
        }

        private static UrlServicoSefaz UrlHomologacaoSvrs()
        {
            return new UrlServicoSefaz
            {
                CteRecepcao = @"https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcao/CTeRecepcao.asmx",
                CteRetRecepcao = @"https://cte-homologacao.svrs.rs.gov.br/ws/cteretrecepcao/CTeRetRecepcao.asmx",
                CteInutilizacao = @"https://cte-homologacao.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                CteConsultaProtocolo = @"https://cte-homologacao.svrs.rs.gov.br/ws/cteconsulta/CTeConsulta.asmx",
                CteStatusServico = @"https://cte-homologacao.svrs.rs.gov.br/ws/ctestatusservico/CTeStatusServico.asmx",
                CteRecepcaoEvento = @"https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcaoevento/CTeRecepcaoEvento.asmx",
                QrCode = @"https://dfe-portal.svrs.rs.gov.br/cte/qrCode",
                ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
            };
        }

        private static UrlServicoSefaz UrlProducao(FusionEstadoUFCTe estado)
        {
            switch (estado)
            {
                case FusionEstadoUFCTe.MT:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://cte.sefaz.mt.gov.br/ctews/services/CteStatusServico",
                        CteRecepcao = "https://cte.sefaz.mt.gov.br/ctews/services/CteRecepcao",
                        CteInutilizacao = "https://cte.sefaz.mt.gov.br/ctews/services/CteInutilizacao",
                        CteRetRecepcao = "https://cte.sefaz.mt.gov.br/ctews/services/CteRetRecepcao",
                        CteRecepcaoEvento = "https://cte.sefaz.mt.gov.br/ctews2/services/CteRecepcaoEvento?wsdl",
                        CteConsultaProtocolo = "https://cte.sefaz.mt.gov.br/ctews/services/CteConsulta",
                        QrCode = @"https://www.sefaz.mt.gov.br/cte/qrcode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.MS:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://producao.cte.ms.gov.br/ws/CteStatusServico",
                        CteRecepcao = "https://producao.cte.ms.gov.br/ws/CteRecepcao",
                        CteInutilizacao = "https://producao.cte.ms.gov.br/ws/CteInutilizacao",
                        CteRetRecepcao = "https://producao.cte.ms.gov.br/ws/CteRetRecepcao",
                        CteRecepcaoEvento = "https://producao.cte.ms.gov.br/ws/CteRecepcaoEvento",
                        CteConsultaProtocolo = "https://producao.cte.ms.gov.br/ws/CteConsulta",
                        QrCode = @"http://www.dfe.ms.gov.br/cte/qrcode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.MG:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://cte.fazenda.mg.gov.br/cte/services/CteStatusServico",
                        CteRecepcao = "https://cte.fazenda.mg.gov.br/cte/services/CteRecepcao",
                        CteInutilizacao = "https://cte.fazenda.mg.gov.br/cte/services/CteInutilizacao",
                        CteRetRecepcao = "https://cte.fazenda.mg.gov.br/cte/services/CteRetRecepcao",
                        CteRecepcaoEvento = "https://cte.fazenda.mg.gov.br/cte/services/RecepcaoEvento",
                        CteConsultaProtocolo = "https://cte.fazenda.mg.gov.br/cte/services/CteConsulta",
                        QrCode = @"https://cte.fazenda.mg.gov.br/portalcte/sistema/qrcode.xhtml",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.PR:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://cte.fazenda.pr.gov.br/cte/CteStatusServico?wsdl",
                        CteRecepcao = "https://cte.fazenda.pr.gov.br/cte/CteRecepcao?wsdl",
                        CteInutilizacao = "https://cte.fazenda.pr.gov.br/cte/CteInutilizacao?wsdl",
                        CteRetRecepcao = "https://cte.fazenda.pr.gov.br/cte/CteRetRecepcao?wsdl",
                        CteRecepcaoEvento = "https://cte.fazenda.pr.gov.br/cte/CteRecepcaoEvento?wsdl",
                        CteConsultaProtocolo = "https://cte.fazenda.pr.gov.br/cte/CteConsulta?wsdl",
                        QrCode = @"http://www.fazenda.pr.gov.br/cte/qrcode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.RS:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://cte.svrs.rs.gov.br/ws/ctestatusservico/CteStatusServico.asmx",
                        CteRecepcao = "https://cte.svrs.rs.gov.br/ws/cterecepcao/CteRecepcao.asmx",
                        CteInutilizacao = "https://cte.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                        CteRetRecepcao = "https://cte.svrs.rs.gov.br/ws/cteretrecepcao/cteRetRecepcao.asmx",
                        CteRecepcaoEvento = "https://cte.svrs.rs.gov.br/ws/cterecepcaoevento/cterecepcaoevento.asmx",
                        CteConsultaProtocolo = "https://cte.svrs.rs.gov.br/ws/cteconsulta/CteConsulta.asmx",
                        QrCode = @"https://dfe-portal.svrs.rs.gov.br/cte/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.SP:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://nfe.fazenda.sp.gov.br/cteWEB/services/cteStatusServico.asmx",
                        CteRecepcao = "https://nfe.fazenda.sp.gov.br/cteWEB/services/cteRecepcao.asmx",
                        CteInutilizacao = "https://nfe.fazenda.sp.gov.br/cteWEB/services/cteInutilizacao.asmx",
                        CteRetRecepcao = "https://nfe.fazenda.sp.gov.br/cteWEB/services/cteRetRecepcao.asmx",
                        CteRecepcaoEvento = "https://nfe.fazenda.sp.gov.br/cteweb/services/cteRecepcaoEvento.asmx",
                        CteConsultaProtocolo = "https://nfe.fazenda.sp.gov.br/cteWEB/services/cteConsulta.asmx",
                        QrCode = @"https://nfe.fazenda.sp.gov.br/CTeConsulta/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.AC:
                case FusionEstadoUFCTe.AL:
                case FusionEstadoUFCTe.AM:
                case FusionEstadoUFCTe.BA:
                case FusionEstadoUFCTe.CE:
                case FusionEstadoUFCTe.DF:
                case FusionEstadoUFCTe.ES:
                case FusionEstadoUFCTe.GO:
                case FusionEstadoUFCTe.MA:
                case FusionEstadoUFCTe.PA:
                case FusionEstadoUFCTe.PB:
                case FusionEstadoUFCTe.PI:
                case FusionEstadoUFCTe.RJ:
                case FusionEstadoUFCTe.RN:
                case FusionEstadoUFCTe.RO:
                case FusionEstadoUFCTe.SC:
                case FusionEstadoUFCTe.SE:
                case FusionEstadoUFCTe.TO:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://cte.svrs.rs.gov.br/ws/ctestatusservico/CteStatusServico.asmx",
                        CteRecepcao = "https://cte.svrs.rs.gov.br/ws/cterecepcao/CteRecepcao.asmx",
                        CteInutilizacao = "https://cte.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                        CteRetRecepcao = "https://cte.svrs.rs.gov.br/ws/cteretrecepcao/cteRetRecepcao.asmx",
                        CteRecepcaoEvento = "https://cte.svrs.rs.gov.br/ws/cterecepcaoevento/cterecepcaoevento.asmx",
                        CteConsultaProtocolo = "https://cte.svrs.rs.gov.br/ws/cteconsulta/CteConsulta.asmx",
                        QrCode = @"https://dfe-portal.svrs.rs.gov.br/cte/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.AP:
                case FusionEstadoUFCTe.PE:
                case FusionEstadoUFCTe.RR:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://nfe.fazenda.sp.gov.br/cteWEB/services/CteStatusServico.asmx",
                        CteRecepcao = "https://nfe.fazenda.sp.gov.br/cteWEB/services/cteRecepcao.asmx",
                        CteInutilizacao = "https://nfe.fazenda.sp.gov.br/cteWEB/services/cteInutilizacao.asmx",
                        CteRetRecepcao = "https://nfe.fazenda.sp.gov.br/cteWEB/services/CteRetRecepcao.asmx",
                        CteRecepcaoEvento = "https://nfe.fazenda.sp.gov.br/cteWEB/services/CteRecepcaoEvento.asmx",
                        CteConsultaProtocolo = "https://nfe.fazenda.sp.gov.br/cteWEB/services/CteConsulta.asmx",
                        QrCode = @"https://nfe.fazenda.sp.gov.br/CTeConsulta/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };
            }

            throw new InvalidOperationException("Sigla estádo uf " + estado + " está inválido");
        }

        private static UrlServicoSefaz UrlHomologacao(FusionEstadoUFCTe estado)
        {
            switch (estado)
            {
                case FusionEstadoUFCTe.MT:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://homologacao.sefaz.mt.gov.br/ctews/services/CteStatusServico",
                        CteRecepcao = "https://homologacao.sefaz.mt.gov.br/ctews/services/CteRecepcao",
                        CteInutilizacao = "https://homologacao.sefaz.mt.gov.br/ctews/services/CteInutilizacao",
                        CteRetRecepcao = "https://homologacao.sefaz.mt.gov.br/ctews/services/CteRetRecepcao",
                        CteRecepcaoEvento = "https://homologacao.sefaz.mt.gov.br/ctews2/services/CteRecepcaoEvento?wsdl",
                        CteConsultaProtocolo = "https://homologacao.sefaz.mt.gov.br/ctews/services/CteConsulta",
                        QrCode = @"https://homologacao.sefaz.mt.gov.br/cte/qrcode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.MS:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://homologacao.cte.ms.gov.br/ws/CteStatusServico",
                        CteRecepcao = "https://homologacao.cte.ms.gov.br/ws/CteRecepcao",
                        CteInutilizacao = "https://homologacao.cte.ms.gov.br/ws/CteInutilizacao",
                        CteRetRecepcao = "https://homologacao.cte.ms.gov.br/ws/CteRetRecepcao",
                        CteRecepcaoEvento = "https://homologacao.cte.ms.gov.br/ws/CteRecepcaoEvento",
                        CteConsultaProtocolo = "https://homologacao.cte.ms.gov.br/ws/CteConsulta",
                        QrCode = @"http://www.dfe.ms.gov.br/cte/qrcode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.MG:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://hcte.fazenda.mg.gov.br/cte/services/CteStatusServico",
                        CteRecepcao = "https://hcte.fazenda.mg.gov.br/cte/services/CteRecepcao",
                        CteInutilizacao = "https://hcte.fazenda.mg.gov.br/cte/services/CteInutilizacao",
                        CteRetRecepcao = "https://hcte.fazenda.mg.gov.br/cte/services/CteRetRecepcao",
                        CteRecepcaoEvento = "https://hcte.fazenda.mg.gov.br/cte/services/RecepcaoEvento",
                        CteConsultaProtocolo = "https://hcte.fazenda.mg.gov.br/cte/services/CteConsulta?wsdl",
                        QrCode = @"https://hcte.fazenda.mg.gov.br/portalcte/sistema/qrcode.xhtml",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.PR:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://homologacao.cte.fazenda.pr.gov.br/cte/CteStatusServico?wsdl",
                        CteRecepcao = "https://homologacao.cte.fazenda.pr.gov.br/cte/CteRecepcao?wsdl",
                        CteInutilizacao = "https://homologacao.cte.fazenda.pr.gov.br/cte/CteInutilizacao?wsdl",
                        CteRetRecepcao = "https://homologacao.cte.fazenda.pr.gov.br/cte/CteRetRecepcao?wsdl",
                        CteRecepcaoEvento = "https://homologacao.cte.fazenda.pr.gov.br/cte/CteRecepcaoEvento?wsdl",
                        CteConsultaProtocolo = "https://homologacao.cte.fazenda.pr.gov.br/cte/CteConsulta?wsdl",
                        QrCode = @"http://www.fazenda.pr.gov.br/cte/qrcode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.RS:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico =
                            "https://cte-homologacao.svrs.rs.gov.br/ws/ctestatusservico/CteStatusServico.asmx",
                        CteRecepcao = "https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcao/CteRecepcao.asmx",
                        CteInutilizacao =
                            "https://cte-homologacao.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                        CteRetRecepcao = "https://cte-homologacao.svrs.rs.gov.br/ws/cteretrecepcao/cteRetRecepcao.asmx",
                        CteRecepcaoEvento =
                            "https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcaoevento/cterecepcaoevento.asmx",
                        CteConsultaProtocolo = "https://cte-homologacao.svrs.rs.gov.br/ws/cteconsulta/CteConsulta.asmx",
                        QrCode = @"https://dfe-portal.svrs.rs.gov.br/cte/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.SP:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteStatusServico.asmx",
                        CteRecepcao = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteRecepcao.asmx",
                        CteInutilizacao = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteInutilizacao.asmx",
                        CteRetRecepcao = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteRetRecepcao.asmx",
                        CteRecepcaoEvento = "https://homologacao.nfe.fazenda.sp.gov.br/cteweb/services/cteRecepcaoEvento.asmx",
                        CteConsultaProtocolo = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteConsulta.asmx",
                        QrCode = @"https://homologacao.nfe.fazenda.sp.gov.br/CTeConsulta/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.AC:
                case FusionEstadoUFCTe.AL:
                case FusionEstadoUFCTe.AM:
                case FusionEstadoUFCTe.BA:
                case FusionEstadoUFCTe.CE:
                case FusionEstadoUFCTe.DF:
                case FusionEstadoUFCTe.ES:
                case FusionEstadoUFCTe.GO:
                case FusionEstadoUFCTe.MA:
                case FusionEstadoUFCTe.PA:
                case FusionEstadoUFCTe.PB:
                case FusionEstadoUFCTe.PI:
                case FusionEstadoUFCTe.RJ:
                case FusionEstadoUFCTe.RN:
                case FusionEstadoUFCTe.RO:
                case FusionEstadoUFCTe.SC:
                case FusionEstadoUFCTe.SE:
                case FusionEstadoUFCTe.TO:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico =
                            "https://cte-homologacao.svrs.rs.gov.br/ws/ctestatusservico/CteStatusServico.asmx",
                        CteRecepcao = "https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcao/CteRecepcao.asmx",
                        CteInutilizacao =
                            "https://cte-homologacao.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                        CteRetRecepcao = "https://cte-homologacao.svrs.rs.gov.br/ws/cteretrecepcao/cteRetRecepcao.asmx",
                        CteRecepcaoEvento =
                            "https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcaoevento/cterecepcaoevento.asmx",
                        CteConsultaProtocolo = "https://cte-homologacao.svrs.rs.gov.br/ws/cteconsulta/CteConsulta.asmx",
                        QrCode = @"https://dfe-portal.svrs.rs.gov.br/cte/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };

                case FusionEstadoUFCTe.AP:
                case FusionEstadoUFCTe.PE:
                case FusionEstadoUFCTe.RR:
                    return new UrlServicoSefaz
                    {
                        CteStatusServico =
                            "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteStatusServico.asmx",
                        CteRecepcao = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRecepcao.asmx",
                        CteInutilizacao =
                            "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteInutilizacao.asmx",
                        CteRetRecepcao = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRetRecepcao.asmx",
                        CteRecepcaoEvento =
                            "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRecepcaoEvento.asmx",
                        CteConsultaProtocolo = "https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteConsulta.asmx",
                        QrCode = @"https://homologacao.nfe.fazenda.sp.gov.br/CTeConsulta/qrCode",
                        ConsultaCTe = @"https://dfe-portal.svrs.rs.gov.br/CTe/Servicos"
                    };
            }

            throw new InvalidOperationException("Sigla estádo uf " + estado + " está inválido");
        }
    }
}