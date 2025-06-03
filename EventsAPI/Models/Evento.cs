using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Models
{
    public class Evento
{
    [Key]
 public int EventosId { get; set; }


 [DataType(DataType.Date)]
 [Display(Name = "Data do Evento:")]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
 public DateTime EVENTO_DATA { get; set; }

 [Display(Name = "Responsável:")]
 public string? EVENTO_RESPONSAVEL { get; set; }

 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
 public DateTime? EVENTO_DATA_ENCERRAMENTO { get; set; }


 [Display(Name = "Status:")]

 public string? EVENTO_STATUS { get; set; }

 [Display(Name = "Gerou contato:")]

 public string? EVENTO_GEROU_CONTATO { get; set; }


 [Display(Name = "Gerou compromisso:")]

 public string? EVENTO_GEROU_COMPROMISSO { get; set; }


 [Display(Name = "Considerações:")]
 public string? MOTIVO { get; set; }


 [Display(Name = "Tipo:")]
 public int? EVENTO_TIPO { get; set; }


 public string? COD_EMPRESA { get; set; }


 [Display(Name = "O.S:")]
 public string? COD_OS_AGENDA { get; set; }

 [Display(Name = "CPF/CNPJ:")]
 public string? COD_CLIENTE { get; set; }

 [Display(Name = "Nome:")]
 public string? NOME { get; set; }

 [Display(Name = "Contato (PJ):")]
 public string? CONTATO { get; set; }

 [Display(Name = "Telefone resid.:")]
 public string? TELEFONE_RES { get; set; }

 [Display(Name = "Celular:")]
 public string? TELEFONE_CEL { get; set; }

 [Display(Name = "E-mail:")]
 public string? ENDERECO_ELETRONICO { get; set; }

 public int? COD_MARCA { get; set; }

 public string? COD_PRODUTO { get; set; }

 public string? COD_MODELO { get; set; }

 [Display(Name = "Descrição:")]
 public string? DESCRICAO_MODELO { get; set; }

 [Display(Name = "Ano do modelo:")]
 public string? ANO_MODELO { get; set; }

 [Display(Name = "Chassi:")]
 public string? CHASSI { get; set; }

 [Display(Name = "Vendedor:")]
 public string? VENDEDOR { get; set; }

 [Display(Name = "Vendedor_Cliente:")]
 public string? VENDEDOR_CLIENTE { get; set; }

 [Display(Name = "Data da venda:")]
 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
 public DateTime? DATA_VENDA { get; set; }

 [Display(Name = "Consultor:")]
 public string? CONSULTOR { get; set; }

 //inserir formatação de horas
 [Display(Name = "Data agendada:")]
 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
 public DateTime? DATA_AGENDADA { get; set; }

 [Display(Name = "Restrição e-mail:")]
 public string? RESTRICAO_EMAIL { get; set; }

 [Display(Name = "Restrição ligação:")]
 public string? RESTRICAO_LIGACAO { get; set; }

 [Display(Name = "Restrição whatsapp:")]
 public string? RESTRICAO_WHATSAPP { get; set; }

 public string? NOVO_USADO { get; set; }

 [Display(Name = "Expira Garantia:")]
 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
 public DateTime? EXPIRA_GARANTIA { get; set; }


 [Display(Name = "Numero da Proposta DMS")]
 public string? N_PROPOSTA { get; set; }


 [Display(Name = "Ultima passagem:")]
 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
 public DateTime? PASSAGEM_DATA { get; set; }

 [Display(Name = "KM ult. passagem:")]
 public int? PASSAGEM_KM { get; set; }

 [Display(Name = "Cidade:")]
 public string? CIDADE { get; set; }


 [Display(Name = "Cliente da ult. Passagem:")]

 public string? PASSAGEM_CLIENTE { get; set; }


 [Display(Name = "Placa:")]
 public string? PLACA { get; set; }


 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
 public DateTime? DATA_ATUALIZACAO { get; set; }


 [Display(Name = "Reclamações OS:")]
 public string? RECLAMACAO { get; set; }


 [Display(Name = "Indicação:")]
 public string? INDICACAO { get; set; }


 [Display(Name = "Idade:")]
 public int IDADE { get; set; }

 [Display(Name = "Aniversário:")]
 public string? ANIVERSARIO { get; set; }


 [Display(Name = "Idade da venda:")]
 public decimal? IDADE_VENDA { get; set; }

 public string? DESCRICAO_ETAPA { get; set; }
 public decimal? VALOR_FINANC { get; set; }

 public decimal? VALOR_PARCELA { get; set; }


 public int? PARCELAS_FINANC { get; set; }

 public string? VEICULO_INTERESSE { get; set; }



 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
 public DateTime? TERMINO_CONTRATO { get; set; }


 [DataType(DataType.Date)]
 [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
 public DateTime? DATA_PROJETADA { get; set; }

 public string? RESPOSTA_CONTATO { get; set; }

 public DateTime? DATA_DISTRIBUICAO { get; set; }

 public int? ANO_FAB { get; set; }

 public int? ANO_MOD { get; set; }

 public DateTime? DATA_AVALIACAO { get; set; }

 public int? KM_AVALIADO { get; set; }

 public decimal? VALOR_AVALIADO { get; set; }
}

}