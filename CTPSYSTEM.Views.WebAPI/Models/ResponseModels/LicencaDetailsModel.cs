﻿using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class LicencaDetailsModel
    {
        /// <summary>
        /// Identificador único do registro de licença
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da carteira de trabalho oa qual
        /// este registro de licença está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Data do inicio da licença
        /// </summary>
        public DateTimeOffset DataInicio { get; set; }

        /// <summary>
        /// Data de término da licença
        /// </summary>
        public DateTimeOffset DataTermino { get; set; }

        /// <summary>
        /// Quantidade de dias que o funcionário ficou de licença
        /// </summary>
        public int Dias { get; set; }

        /// <summary>
        /// Código do posto que afastou o funcionário
        /// </summary>
        public int CodigoPosto { get; set; }

        /// <summary>
        /// Motivo do afastamento.
        /// OBS: Esse campo é opcional e não existe na carteira de trabalho física
        /// </summary>
        public string Motivo { get; set; }

        public static implicit operator LicencaDetailsModel(Licenca licenca)
        {
            LicencaDetailsModel model = new LicencaDetailsModel();

            model.Id = licenca.Id;
            model.IdCarteiraTrabalho = licenca.IdCarteiraTrabalho;
            model.DataInicio = licenca.DataInicio;
            model.DataTermino = licenca.DataTermino;
            model.Dias = licenca.Dias;
            model.CodigoPosto = licenca.CodigoPosto;

            return model;
        }
    }
}