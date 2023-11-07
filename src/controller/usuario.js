const usuarioQuery =   require("../reository/usuario")

const detalharUsuario = async (req, res) => {
    const { id } = req.query;
    const usuario = await usuarioQuery.buscarUsuarioPorID(id);
    return res.status(200).json(usuario);
  };


  const cadastrarUsuario = async (req, res) => {
    const {name,phone,email} = req.body;
    const usuario = await usuarioQuery.cadastrarUsuario(name,phone,email);
    return res.status(200).json("");
  };


  const AtualizarUsuario = async (req, res) => {
    const {id,name,phone,email} = req.body;
    const usuario = await usuarioQuery.atualizarDadosUsuario(id,name,phone,email);
    return res.status(200).json("");
  };
  
  const ExcluirUsuario = async (req, res) => {
    const {id} = req.body;
    const usuario = await usuarioQuery.excluirDadosUsuario(id);
    return res.status(200).json("");
  };


module.exports = {detalharUsuario,cadastrarUsuario,AtualizarUsuario,ExcluirUsuario};
