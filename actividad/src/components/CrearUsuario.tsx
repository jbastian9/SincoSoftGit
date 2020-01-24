import React, { useState } from "react";
import { Button, Modal, Container, Form } from "react-bootstrap";
const CrearUsuario: React.FC = () => {
  const [CrearUsu, setCrearUsu] = useState(false);
  return (
    <Container>
      <Button variant="secondary" onClick={() => setCrearUsu(true)} block>
        CREAR USUARIO
      </Button>
      <Modal show={CrearUsu} onHide={() => setCrearUsu(false)}>
        <Modal.Header closeButton>
          <Modal.Title>CREAR USUARIO</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form.Label className="inputUsuario">Nombre</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="text"
            placeholder="Johan"
          />
          <Form.Label className="inputUsuario">Apellido</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="text"
            placeholder="Quintero"
          />
          <Form.Label className="inputUsuario">Correo</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="email"
            placeholder="jbastian9@hotmail.com"
          />
          <Form.Label className="inputUsuario">Teléfono</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="text"
            placeholder="3234721056"
          />
          <Form.Label className="inputUsuario">País</Form.Label>
          <Form.Control className="inputUsuario" as="select">
            <option>--Desplegar--</option>
            <option>eeuu</option>
            <option>chl</option>
            <option>mex</option>
            <option>arg</option>
          </Form.Control>
          <Form.Label className="inputUsuario">Ciudad</Form.Label>
          <Form.Control className="inputUsuario" as="select">
            <option>--Desplegar--</option>
            <option>2</option>
            <option>3</option>
            <option>4</option>
            <option>5</option>
          </Form.Control>
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={() => setCrearUsu(false)}>
            CANCELAR
          </Button>
          <Button variant="primary" onClick={() => setCrearUsu(false)}>
            GUARDAR
          </Button>
        </Modal.Footer>
      </Modal>
    </Container>
  );
};
export default CrearUsuario;
