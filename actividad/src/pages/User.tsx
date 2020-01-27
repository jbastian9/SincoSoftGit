import React, { useState } from "react";
import { Container, Table, Button, Row, Col, Navbar } from "react-bootstrap";
import { Usuario } from "../models/Model";
import CrearUsuario from "../components/CrearUsuario";
import ModificarUsuario from "../components/ModificarUsuario";

const usuarios: Usuario[] = [
  {
    id: "1",
    nombre: "Juan",
    apellido: "Paez",
    correo: "jaun@sinco.com",
    telefono: "3222123212231",
    pais: "Mex",
    ciudad: "Bog"
  },
  {
    id: "2",
    nombre: "Lina",
    apellido: "Gomez",
    correo: "Ojeda@sinco.com",
    telefono: "3222123212231",
    pais: "Col",
    ciudad: "Bog"
  },
  {
    id: "2",
    nombre: "Lina",
    apellido: "Gomez",
    correo: "Ojeda@sinco.com",
    telefono: "3222123212231",
    pais: "Col",
    ciudad: "Bog"
  },
  {
    id: "3",
    nombre: "Daniela",
    apellido: "Ojeda",
    correo: "Ojeda@sinco.com",
    telefono: "3222123212231",
    pais: "Arg",
    ciudad: "Bog"
  }
];

const User: React.FC = () => {
  const [traerDatosUsuario, setTraerDatosUsuario] = useState<Usuario | null>(
    null
  );

  const [
    mostarModalModificarUsuario,
    setMostrarModalModificarUsuario
  ] = useState(false);

  const ocultarModalUsuario = () => {
    setMostrarModalModificarUsuario(false);
  };
  function viewModal(usuario: Usuario) {
    setMostrarModalModificarUsuario(true);
    setTraerDatosUsuario(usuario);
  }
  return (
    <Container fluid>
      <Navbar
        bg="dark"
        variant="dark"
        className="tituloTbl"
        style={{ color: "white", marginTop: "20px" }}
      >
        <h4>INFORME USUARIOS</h4>
      </Navbar>
      <Table
        responsive
        striped
        bordered
        hover
        variant="dark"
        style={{ marginTop: "30px" }}
      >
        <thead>
          <tr>
            <th>ID</th>
            <th>NOMBRE</th>
            <th>APELLIDO</th>
            <th>CORREO</th>
            <th>TELÉFONO</th>
            <th>PAÍS</th>
            <th>CIUDAD</th>
            <th>ACCIÓN</th>
          </tr>
        </thead>
        <tbody>
          {usuarios.map((usuario, idx) => {
            return (
              <tr key={usuario.id}>
                <td>{usuario.id}</td>
                <td>{usuario.nombre}</td>
                <td>{usuario.apellido}</td>
                <td>{usuario.correo}</td>
                <td>{usuario.telefono}</td>
                <td>{usuario.pais}</td>
                <td>{usuario.ciudad}</td>
                <td>
                  <Button
                    variant="secondary"
                    block
                    onClick={() => viewModal(usuario)}
                  >
                    MODIFICAR
                  </Button>
                </td>
              </tr>
            );
          })}
        </tbody>
      </Table>
      <Row>
        <Col xs={3}>
          <CrearUsuario />
        </Col>
      </Row>
      <ModificarUsuario
        view={mostarModalModificarUsuario}
        ocultar={ocultarModalUsuario}
        datosUsuario={traerDatosUsuario}
      />
    </Container>
  );
};
export default User;
