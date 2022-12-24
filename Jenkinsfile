pipeline {
  agent {
    node {
      label 'win-agent'
    }

  }
  stages {
    stage('Clean') {
      steps {
        bat 'saphira -DskipTests clean'
      }
    }

  }
}