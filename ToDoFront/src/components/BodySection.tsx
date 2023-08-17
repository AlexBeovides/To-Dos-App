import '../styles/BodySection.scss';
import { ToDo } from './ToDo';

export function BodySection() {
    
    return (
      <div className={`body-section`}>
        <div className='todos-container'>
          <ToDo id={1} task='comprar pan' />
          <ToDo id={2} task='Si ya sabes lo que tienes que hacer y no lo haces, entonces estás peor que antes. Saber que se sabe lo que se sabe y que no se sabe lo que no se sabe; he aquí el verdadero saber. Cada cosa tiene su belleza, pero no todos pueden verla. Debes tener siempre fría la cabeza, caliente el corazón y larga la mano.'/> 
          <ToDo id={3} task='Si quieres cambiar al mundo, cámbiate a ti mismo' />
          <ToDo id={4} task='El espacio y el tiempo son el marco dentro del cual la mente es presionada a construir su experiencia de la realidad.' />
          <ToDo id={5} task='comprar mas pan' />
        </div>

       

        <div className='spacer'></div>
      </div>
    )
}