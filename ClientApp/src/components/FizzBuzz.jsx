import React, { Component } from "react";
import { Button } from "antd";
import axios from "axios";

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

    render() {
        return (
            <div>
                <Button onClick={this.handleExecuteFizzBuzz} type="primary">
                    Execute FizzBuzz Test
        </Button>
                <Button onClick={this.handleCleanBoard} type="primary">
                    Clean Board
        </Button>
                <ul>
                    {this.state.FizzBuzzList.map((i, index) => (
                        <li key={index}>{i}</li>
                    ))}
                </ul>
            </div>
        );
    }
}

export default FizzBuzz;
