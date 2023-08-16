import './styles/_main.scss'
import { TopSection } from './components/TopSection.tsx'
import { BodySection } from './components/BodySection.tsx'
import { BottomSection } from './components/BottomSection.tsx'

function App() {
  return (
    <>
      <div className='main-container'>
        <TopSection></TopSection>
        <BodySection></BodySection>
        <BottomSection></BottomSection>
      </div>
    </>
  )
}

export default App
