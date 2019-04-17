# Hero Database

(.NET demo function)

**N.B: The project in this repository corresponds to the demo project presented in my Solving .NET Cold Starts blog series.**

_Blog Links: [ [1](https://medium.com/thundra/the-fundamental-problem-solving-net-lambda-cold-start-part-i-1ff4400bb6eb) ] [ [2]() ]_

## [Blog I](https://medium.com/thundra/the-fundamental-problem-solving-net-lambda-cold-start-part-i-1ff4400bb6eb)

The first article is meant to highlight the specific problems related to .NET which result in longer cold start durations, as compared to other runtimes on the AWS Lambda platform. the core problem identified is the the stress of jitting .NET assemblies when setting up ephemeral containers.

## [Blog II]()

The second part of the article is aimed at providing specific solutions for .NET on AWS Lambda. These solutions are based on the problems identifed in the [first part](https://medium.com/thundra/the-fundamental-problem-solving-net-lambda-cold-start-part-i-1ff4400bb6eb) of the series. It also uses the demo project in this repository to demonstrate the affect of moving .NET assemblies to AWS Layers.

_For any comments and feedback, you can get in touch with me at my twitter handler [@SarjeelY](https://twitter.com/SarjeelY), or you may email me directly as sarj93@gmail.com_
