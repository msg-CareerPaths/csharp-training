## 3.1. Using Angular vs. React vs. Vue

There are three frameworks for building web applications that every frontend developer has heard about: React, Vue, and Angular.
React is a UI library, Angular is a fully-fledged front-end framework, while Vue.js is a progressive framework.
They can be used almost interchangeably to build front-end applications, but they’re not 100 percent the same, so it makes sense to compare them and understand their differences.
Each framework is component-based and allows the rapid creation of UI features.

* [Angular](https://github.com/ro-msg-angular-training/resources) AngularJS, the original framework, is an MVC (Model-View-Controller)) framework. But in Angular 2, there’s no strict association with MV*-patterns as it is also component-based.
Projects in Angular are structured into Modules, Components, and Services. Each Angular application has at least one root component and one root module. Each component in Angular contains a Template, a Class that defines the application logic, and MetaData (Decorators). The metadata for a component tells Angular where to find the building blocks that it needs to create and present its view.

* [React](https://github.com/ro-msg-react-training/resources) is based on JavaScript, but it’s mostly combined with JSX (JavaScript XML), a syntax extension that allows you to create elements that contain HTML and JavaScript at the same time.
Anything you create with JSX could also be created with the React JavaScript API, but most developers prefer JSX because it’s more intuitive.

* [Vue](https://vuejs.org/guide/introduction.html) The Vue.js core library focuses on the View layer only. It’s called a progressive framework because you can extend its functionality with official and third-party packages, such as Vue Router or Vuex, to turn it into an actual framework.
Although Vue is not strictly associated with the MVVM (Model-View-ViewModel) pattern, its design was partly inspired by it. With Vue, you’ll be working mostly on the ViewModel layer, to make sure that the application data is processed in a way that allows the framework to render an up-to-date View.