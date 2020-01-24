import React from "react";
import { Container, Row, Col, Button } from "react-bootstrap";
import { BrowserRouter, Route, Link } from "react-router-dom";
import User from "./User";
import Contact from "./Contact";
import Mail from "./Mail";

const Home: React.FC = () => {
  return (
    <Container fluid>
      <Row style={{ backgroundColor: "black", color: "white" }}>
        <Col xs={4}>
          <div className="HomeHead">
            <Link to="/">
              <h3
                style={{
                  marginTop: "5px",
                  marginBottom: "5px",
                  MozBorderRadius: "2px"
                }}
              >
                HOME
              </h3>
            </Link>
          </div>
        </Col>
        <Col xs={8}>
          <Row style={{ marginTop: "1px" }}>
            <Col>
              <Link to="/User">
                <Button
                  block
                  variant="secondary"
                  style={{
                    marginTop: "5px",
                    marginBottom: "5px",
                    MozBorderRadius: "2px"
                  }}
                >
                  USUARIOS
                </Button>
              </Link>
            </Col>
            <Col>
              <Button
                block
                variant="secondary"
                style={{
                  marginTop: "5px",
                  marginBottom: "5px",
                  MozBorderRadius: "2px"
                }}
              >
                CONTACTOS
              </Button>
            </Col>
            <Col>
              <Button
                block
                variant="secondary"
                style={{
                  marginTop: "5px",
                  marginBottom: "5px",
                  MozBorderRadius: "2px"
                }}
              >
                CORREOS
              </Button>
            </Col>
          </Row>
        </Col>
      </Row>
      <Row style={{ backgroundColor: "grey" }}>
        <Col xs={12}>
          <div style={{ height: "898px" }}>
            <BrowserRouter>
              <Route path="/User" exact component={User} />
              <Route path="/Contact" exact component={Contact} />
              <Route path="/Mail" exact component={Mail} />
            </BrowserRouter>
          </div>
        </Col>
      </Row>
      <Row style={{ backgroundColor: "black" }}>
        <Col xs={12}>
          <div style={{ height: "30px" }}></div>
        </Col>
      </Row>
    </Container>
  );
};
export default Home;
