import React from "react";
import { Button, Modal, Container, Form } from "react-bootstrap";
import { Usuario } from "../models/Model";

interface IPropsModificarUsuario {
  view: boolean;
  ocultar: () => void;
  datosUsuario: Usuario | null;
}

const ModificarUsuario: React.FC<IPropsModificarUsuario> = props => {
  return (
    <Container>
      <Modal show={props.view} onHide={props.ocultar}>
        <Modal.Header closeButton>
          <Modal.Title>MODIFICAR USUARIO</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form.Label className="inputUsuario">Nombre</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="text"
            defaultValue={props.datosUsuario?.nombre}
          />
          <Form.Label className="inputUsuario">Apellido</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="text"
            defaultValue={props.datosUsuario?.apellido}
          />
          <Form.Label className="inputUsuario">Correo</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="email"
            defaultValue={props.datosUsuario?.correo}
            disabled
          />
          <Form.Label className="inputUsuario">Teléfono</Form.Label>
          <Form.Control
            className="inputUsuario"
            type="text"
            defaultValue={props.datosUsuario?.telefono}
          />
          <Form.Label className="inputUsuario">País</Form.Label>
          <Form.Control className="inputUsuario" as="select">
            <option
              value={props.datosUsuario?.pais}
              label={props.datosUsuario?.pais}
            ></option>
            <option>eeuu</option>
            <option>chl</option>
            <option>mex</option>
            <option>arg</option>
          </Form.Control>
          <Form.Label className="inputUsuario">Ciudad</Form.Label>
          <Form.Control className="inputUsuario" as="select">
            <option
              value={props.datosUsuario?.ciudad}
              label={props.datosUsuario?.ciudad}
            ></option>
            <option>2</option>
            <option>3</option>
            <option>4</option>
            <option>5</option>
          </Form.Control>
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={props.ocultar}>
            CANCELAR
          </Button>
          <Button variant="primary" onClick={props.ocultar}>
            GUARDAR
          </Button>
        </Modal.Footer>
      </Modal>
    </Container>
  );
};
export default ModificarUsuario;
