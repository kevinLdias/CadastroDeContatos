﻿using Controlecontatos.Models;

namespace Controlecontatos.Repositorio;

public interface IContatoRepositorio
{
    ContatoModel ListarPorId(int id);
    List<ContatoModel> BuscarTodos();
    ContatoModel Adicionar(ContatoModel contato);
    ContatoModel Atualizar(ContatoModel contato);
    bool Remover(int id);
     
}