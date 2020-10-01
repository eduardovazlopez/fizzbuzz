import React, { Component } from "react";
import { Button, Row, Col, Card } from "antd";
import axios from "axios";
import _ from "lodash";

export class FizzBuzz extends Component {
    state = {
        FizzBuzzList: [],
    };

    handleExecuteFizzBuzz = async () => {
        const { data: response } = await axios.get(
            "https://localhost:5001/api/fizzbuzz"
        );
        this.setState({ FizzBuzzList: response });
        console.log("Hola Eduardo", response);
    };

    handleCleanBoard = () => this.setState({ FizzBuzzList: [] });

    formatUL = (elementList) => {
        let content = [];
        let slice = [];
        let i = 0;

        while (i < elementList.length) {
            console.log("Hola de nuevo", i, elementList.length);

            slice = _.slice(elementList, i, i + 20);
            content.push(
                <Col key={i}>
                    <Card hoverable key={i} style={{ width: 200 }}>
                        <ul key={i}>
                            {slice.map((e, index) => (
                                <li id={i + index} name="FBli" key={i + index}>{e}</li>
                            ))}
                        </ul>
                    </Card>
                </Col>
            );
            i += 20;
        }

        return (
            <div>
                <Row>{content}</Row>
            </div>
        );
    };

    render() {
        return (
            <div>
                <Button
                    className="m-3"
                    onClick={this.handleExecuteFizzBuzz}
                    type="primary"
                    id="RunTestButton"
                >
                    Execute FizzBuzz Test
        </Button>
                <Button className="m-3" onClick={this.handleCleanBoard} type="primary" id="CleanButton">
                    Clean Board
        </Button>
                {this.formatUL(this.state.FizzBuzzList)}
            </div>
        );
    }
}

export default FizzBuzz;
