import React from "react";
import { Container, Table } from "react-bootstrap";
const User: React.FC = () => {
  return (
    <Container fluid>
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
            <th>CORREO</th>
            <th>TELÉFONO</th>
            <th>PAÍS</th>
            <th>CIUDAD</th>
            <th>ACCIÓN</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>1</td>
            <td>sadasdsa</td>
            <td>asdasda</td>
            <td>asdsadasdasdasd</td>
            <td>asdasdas</td>
            <td>sadassadas</td>
            <td>asdasd</td>
          </tr>
        </tbody>
      </Table>
    </Container>
  );
};
export default User;
